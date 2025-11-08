using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyModels.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class seedauth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24d1e35d-b905-4b83-b973-5ca7244f98e9", null, "Instructor", "INSTRUCTOR" },
                    { "3985c2f3-6d6b-4725-9bf9-f203071b385f", null, "Admin", "ADMIN" },
                    { "808d396c-edb1-439b-b253-9bbf5c41c121", null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "07f10359-ddf5-455e-ab18-f286c37c175c", 0, "21f26601-e17d-4219-897d-5f67da139129", "admin@gmail.gov", false, false, null, "ADMIN@GMAIL.GOV", "ADMIN@GMAIL.GOV", "AQAAAAIAAYagAAAAEIGk7Ue9WOa0267HnSX9ab368lLtyCkD4TRzFd0YiWQqlXSc+Aap3NqI4lSysW0Hsw==", null, false, "018376ac-9d1c-4035-9ed6-e8f9d6989fc2", false, "admin@gmail.gov" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3985c2f3-6d6b-4725-9bf9-f203071b385f", "07f10359-ddf5-455e-ab18-f286c37c175c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24d1e35d-b905-4b83-b973-5ca7244f98e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "808d396c-edb1-439b-b253-9bbf5c41c121");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3985c2f3-6d6b-4725-9bf9-f203071b385f", "07f10359-ddf5-455e-ab18-f286c37c175c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3985c2f3-6d6b-4725-9bf9-f203071b385f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07f10359-ddf5-455e-ab18-f286c37c175c");
        }
    }
}
