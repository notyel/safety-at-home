using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafetyAtHome.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                schema: "auth",
                table: "Users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "auth",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedAt",
                schema: "auth",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                schema: "auth",
                table: "Users",
                type: "uuid",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "auth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "auth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                schema: "auth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                schema: "auth",
                table: "Users");
        }
    }
}
