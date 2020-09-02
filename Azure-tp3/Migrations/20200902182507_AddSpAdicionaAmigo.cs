using Microsoft.EntityFrameworkCore.Migrations;

namespace Azure_tp3.Migrations
{
    public partial class AddSpAdicionaAmigo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE PROCEDURE [dbo].[AdicionarAmigo]
	            @Nome nvarchar(max),
	            @Telefone nvarchar(max),
	            @Email nvarchar(max),
	            @DataAniversario datetime2(7)
            AS
	            INSERT INTO [dbo].[Amigo] ([Nome], [Telefone], [Email], [DataAniversario])
	            VALUES (@Nome, @Telefone, @Email, @DataAniversario)
            RETURN 0
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            DROP PROCEDURE [dbo].[AdicionarAmigo]
            ");
        }
    }
}
