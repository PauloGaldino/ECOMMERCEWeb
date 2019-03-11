using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECOMMERCE.Infrastructure.Migrations
{
    public partial class Configura_Relacionamento_Email : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailPessoa");

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Email",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Email_PessoaId",
                table: "Email",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Email_Pessoa_PessoaId",
                table: "Email",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Email_Pessoa_PessoaId",
                table: "Email");

            migrationBuilder.DropIndex(
                name: "IX_Email_PessoaId",
                table: "Email");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Email");

            migrationBuilder.CreateTable(
                name: "EmailPessoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailId = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailPessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailPessoa_Email_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Email",
                        principalColumn: "EmailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailPessoa_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmailPessoa_EmailId",
                table: "EmailPessoa",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailPessoa_PessoaId",
                table: "EmailPessoa",
                column: "PessoaId");
        }
    }
}
