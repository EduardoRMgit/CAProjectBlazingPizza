using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace C4.NorthWind.BlazingPizza.DataContexts.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float(8)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Queso extra", 23.5 },
                    { 2, "Tocino de pavo", 28.800000000000001 },
                    { 3, "Tocino de jabalí", 28.800000000000001 },
                    { 4, "Tocino de ternera", 28.800000000000001 },
                    { 5, "Té y bollos", 47.0 },
                    { 6, "Bollos recién horneados", 43.5 },
                    { 7, "Pimiento", 9.0 },
                    { 8, "Cebolla", 9.0 },
                    { 9, "Champiñones", 9.0 },
                    { 10, "Pepperoni", 9.0 },
                    { 11, "Salchicha de pato", 30.800000000000001 },
                    { 12, "Albóndigas de venado", 24.5 },
                    { 13, "Cubierta de langosta", 612.5 },
                    { 14, "Caviar de esturión", 965.25 },
                    { 15, "Corazones de alcachofa", 32.600000000000001 },
                    { 16, "Tomates frescos", 19.0 },
                    { 17, "Albahaca", 19.0 },
                    { 18, "Filete", 80.5 },
                    { 19, "Pimientos picantes", 39.799999999999997 },
                    { 20, "Pollo búfalo", 48.0 },
                    { 21, "Queso azul", 24.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Toppings");
        }
    }
}
