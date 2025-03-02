using C1.NorthWind.BlazingPizza.PlaceOrder.Entities.Dtos;
using C2.NorthWind.BlazingPizza.PlaceOrder.BusinessObjects.Interfaces;
using C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.DataContexts;
using C3.NorthWind.BlazingPizza.PlaceOrder.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.NorthWind.BlazingPizza.PlaceOrder.Repositories
{
    // QUÉ VOY A NECESITAR? EL DATA CONTEXT
    internal class PlaceOrderRepository(PlaceOrderContext context) : IPlaceOrderRepository
    {
        public async Task<int> PlaceOrderAsync(PlaceOrderOrderDto order)
        {
            // Order entidad ()
            Order NewOrder = new Order();
            NewOrder.CreatedTime = DateTime.Now;
            NewOrder.Pizzas = order.Pizzas
                .Select(p => new CustomPizza
                {
                    PizzaSpecialId = p.PizzaSpecialId,
                    Size = p.Size,
                    Toppings = p.ToppingsIds
                    .Select(id => new CustomPizzaTopping
                    {
                        ToppingId = id
                    }).ToList(),
                    TotalPrice = p.TotalPrice
                }).ToList();

            NewOrder.DeliveryAddress = new Address
            {
                Name = order.DeliveryAddress.Name,
                AddressLine1 = order.DeliveryAddress.AddressLine1,
                AddressLine2 = order.DeliveryAddress.AddressLine2,
                City = order.DeliveryAddress.City,
                Region = order.DeliveryAddress.Region,
                PostalCode = order.DeliveryAddress.PostalCode
            };

            // esta en memoria
            context.Add(NewOrder);
            // Entity framework, lanza un inset y un select entity
            await context.SaveChangesAsync();

            return NewOrder.Id;

        }
    }
}
