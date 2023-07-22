using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT into products (name, description, price, imageurl, stockcount, registerdate, categoryid)" +
                "values ('Fonte ATX EVGA 550 BP', '80+ BRONZE 550W, 3 Year Warranty, Compact 120mm Size, Power Supply 100-BP-0550-K1', 259.99, '100-BP-0550-K1.jpg', 5, now(), 1)");
            migrationBuilder.Sql(
                "INSERT into products (name, description, price, imageurl, stockcount, registerdate, categoryid)" +
                "values ('Mouse Gamer Logitech G502 HERO', 'com RGB LIGHTSYNC, Ajustes de Peso, 11 Botões Programáveis, Sensor HERO 25K - 910-005550', 269.99, 'G502_HERO.jpg', 10, now(), 2)");
            migrationBuilder.Sql(
                "INSERT into products (name, description, price, imageurl, stockcount, registerdate, categoryid)" +
                "values ('Monitor LG LED 23.8´', 'IPS, Full HD, HDMI, VESA, Ajuste de Ângulo - 24MK430H', 639.99, 'LG_24MK430H.jpg', 1, now(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "delete from products where id != 0;" +
                "alter table products AUTO_INCREMENT = 1");
        }
    }
}
