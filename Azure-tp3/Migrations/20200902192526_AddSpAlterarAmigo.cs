using Microsoft.EntityFrameworkCore.Migrations;

namespace Azure_tp3.Migrations
{
    public partial class AddSpAlterarAmigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE PROCEDURE [dbo].[AlterarAmigo]
                @Id int,
	            @Nome nvarchar(max),
	            @Telefone nvarchar(max),
	            @Email nvarchar(max),
	            @DataAniversario datetime2(7)
            AS
                UPDATE AMIGO SET
                NOME = @Nome,
                TELEFONE = @Telefone,
                EMAIL = @Email,
                DATAANIVERSARIO = @DataAniversario
                WHERE ID = @Id
	            
            RETURN 0
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            DROP PROCEDURE [dbo].[AlterarAmigo]
            ");
        }
    }
}
