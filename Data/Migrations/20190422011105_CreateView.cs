using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CreateView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var query = "CREATE VIEW V_Product AS " +
                          "SELECT P.ProductId,P.ProductName,P.UnitPrice,P.UnitInStock,C.CategoryName " +
                          "FROM dbo.Product AS P INNER JOIN dbo.Category AS C " +
                          "ON P.CategoryId = C.CategoryId";

            migrationBuilder.CreateOrDeleteView(query);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var query = "DROP VIEW V_Product";
            migrationBuilder.CreateOrDeleteView(query);
        }
    }
}
