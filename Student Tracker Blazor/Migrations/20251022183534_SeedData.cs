using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentTrackerBlazor.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Test1",
                columns: new[] { "Id", "Name", "TestOne" },
                values: new object[] { 1, "TestOne", "Success" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Test1",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
