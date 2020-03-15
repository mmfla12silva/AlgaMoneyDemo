using Microsoft.EntityFrameworkCore.Migrations;

namespace AlgaMoney.Infra.Data.Migrations
{
    public partial class InclusaodocampovalorMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Lancamentos",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Lancamentos");
        }
    }
}
