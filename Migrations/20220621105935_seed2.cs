using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIOgVueAvslutning.Migrations
{
    public partial class seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Coockies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Coockies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Cookie with chocolate bites ", "Chocolate Cookie" });

            migrationBuilder.InsertData(
                table: "Coockies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent eu quam pretium, maximus ligula non, lobortis elit. Nulla tristique facilisis erat, vel accumsan velit. Proin maximus tortor non nulla egestas, ac iaculis quam malesuada. Phasellus at volutpat diam. Aliquam vulputate a est ac posuere. Integer dignissim arcu vitae eros faucibus, sed iaculis tortor cursus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", "Blueberry Cookie" });

            migrationBuilder.InsertData(
                table: "Coockies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent eu quam pretium, maximus ligula non, lobortis elit. Nulla tristique facilisis erat, vel accumsan velit. Proin maximus tortor non nulla egestas, ac iaculis quam malesuada. Phasellus at volutpat diam. Aliquam vulputate a est ac posuere. Integer dignissim arcu vitae eros faucibus, sed iaculis tortor cursus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos", "Apple Cookie" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Chocolate" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Flour" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Apple" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Egg" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Sugar" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Blueberry" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Milk" });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 1, 7 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 2, 4 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 2, 6 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 2, 7 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 3, 4 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 3, 5 });

            migrationBuilder.InsertData(
                table: "CoockiesIngredients",
                columns: new[] { "CoockiesId", "IngredientsId" },
                values: new object[] { 3, 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "CoockiesIngredients",
                keyColumns: new[] { "CoockiesId", "IngredientsId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "Coockies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coockies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coockies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Coockies");
        }
    }
}
