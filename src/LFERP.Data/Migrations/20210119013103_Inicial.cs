using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LFERP.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Cadastro");

            migrationBuilder.CreateTable(
                name: "Pais",
                schema: "Cadastro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Codigo = table.Column<string>(type: "VARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                schema: "Cadastro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Sigla = table.Column<string>(type: "VARCHAR(2)", nullable: false),
                    IdPais = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estado_IdPais",
                        column: x => x.IdPais,
                        principalSchema: "Cadastro",
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                schema: "Cadastro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UNIQUEIDENTIFIER", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(MAX)", nullable: false),
                    IdEstado = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidade_IdEstado",
                        column: x => x.IdEstado,
                        principalSchema: "Cadastro",
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ceps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodigoEnderecamentoPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCidade = table.Column<Guid>(type: "UNIQUEIDENTIFIER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ceps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cep_IdCidade",
                        column: x => x.IdCidade,
                        principalSchema: "Cadastro",
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ceps_IdCidade",
                table: "Ceps",
                column: "IdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_IdEstado",
                schema: "Cadastro",
                table: "Cidade",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Estado_IdPais",
                schema: "Cadastro",
                table: "Estado",
                column: "IdPais");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ceps");

            migrationBuilder.DropTable(
                name: "Cidade",
                schema: "Cadastro");

            migrationBuilder.DropTable(
                name: "Estado",
                schema: "Cadastro");

            migrationBuilder.DropTable(
                name: "Pais",
                schema: "Cadastro");
        }
    }
}
