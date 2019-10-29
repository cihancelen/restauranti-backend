using Microsoft.EntityFrameworkCore.Migrations;

namespace Restauranti.DAL.Migrations
{
    public partial class AppUserAddRestaurantId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ResturantId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResturantId",
                table: "AspNetUsers");
        }
    }
}
