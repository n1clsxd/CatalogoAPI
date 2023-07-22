using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT into categories(name, imageurl) values ('hardware', 'hardware.jpg');" +
                "INSERT into categories(name, imageurl) values ('periféricos', 'periféricos.jpg');" +
                "INSERT into categories(name, imageurl) values ('monitores', 'monitores.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "delete from categories where id != 0;" +
                "alter table categories AUTO_INCREMENT = 1");
        }
    }
}
