using Microsoft.EntityFrameworkCore.Migrations;

namespace Azure_tp3.Migrations
{
    public partial class AddSpExcluirAmigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE PROCEDURE [dbo].[ExcluirAmigo]
	            @Id int
            AS
	            delete from Amigo where id = @Id
            RETURN 0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            DROP PROCEDURE [dbo].[ExcluirAmigo]
	        ");
        }
    }
}
