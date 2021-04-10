using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorContactsApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "City", "Name", "State", "Zip" },
                values: new object[,]
                {
                    { 1, "123 Test St", "Overland Park", "Carol Mason", "KS", "66202" },
                    { 2, "234 MyStreet", "Overland Park", "Amy Montoni", "KS", "66207" },
                    { 3, "123 Way", "Overland Park", "Robert Morris", "KS", "66207" },
                    { 4, "123 Example St", "Overland Park", "Richard Thurmond", "KS", "66202" },
                    { 5, "110 Example St", "Overland Park", "Michelle Williams", "KS", "66202" },
                    { 6, "123 Second", "Overland Park", "Herbert White", "KS", "66207" },
                    { 7, "234 First", "Overland Park", "Rick Thames", "KS", "66202" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
