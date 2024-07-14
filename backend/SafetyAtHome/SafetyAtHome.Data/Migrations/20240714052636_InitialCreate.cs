using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafetyAtHome.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "auth");

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            // Crear el usuario admin por defecto
            var passwordHasher = new SafetyAtHome.Common.Utilities.PasswordHasher();
            var hashedPassword = passwordHasher.Hash("admin123");

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Users",
                columns: new[] { "Id", "Username", "Email", "PasswordHash", "CreatedAt" },
                values: new object[]
                {
                Guid.NewGuid(),
                "admin",
                "admin@example.com",
                hashedPassword,
                DateTime.UtcNow
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users",
                schema: "auth");
        }
    }
}
