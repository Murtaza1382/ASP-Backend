using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_RazorPagesMovie.Migrations
{
    /// <inheritdoc />
    public partial class ChangeReleaseDateToDateOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "ReleaseDate",
                table: "Movie",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movie",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }
    }
}
