using Microsoft.EntityFrameworkCore.Migrations;

namespace Azure_tp3.Migrations
{
    public partial class AddSpBuscarAmigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" 
                CREATE PROCEDURE [dbo].[BuscarAmigo]
                AS
	                select * from Amigo
                RETURN 0
            ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" 
                DROP PROCEDURE [dbo].[BuscarAmigo]
            ");
        }
    }
}
