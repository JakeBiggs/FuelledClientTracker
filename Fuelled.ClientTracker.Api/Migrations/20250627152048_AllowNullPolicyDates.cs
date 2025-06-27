using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fuelled.ClientTracker.Api_New.Migrations
{
    /// <inheritdoc />
    public partial class AllowNullPolicyDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Clients",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RenewalDate",
                table: "Clients",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Clients",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RenewalDate",
                table: "Clients",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);
        }
    }
}