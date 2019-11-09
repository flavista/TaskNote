using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskNote.Migrations
{
    public partial class TaskNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizarras",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizarras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planners",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contenedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    PizarraId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contenedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contenedores_Pizarras_PizarraId",
                        column: x => x.PizarraId,
                        principalTable: "Pizarras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    NombreUsuario = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PlannerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Planners_PlannerId",
                        column: x => x.PlannerId,
                        principalTable: "Planners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarjetas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    ContenedorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjetas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarjetas_Contenedores_ContenedorId",
                        column: x => x.ContenedorId,
                        principalTable: "Contenedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosPizarra",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PizarraId = table.Column<int>(nullable: false),
                    PizarraId1 = table.Column<Guid>(nullable: true),
                    UsuarioId = table.Column<Guid>(nullable: false),
                    Confirmado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosPizarra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuariosPizarra_Pizarras_PizarraId1",
                        column: x => x.PizarraId1,
                        principalTable: "Pizarras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuariosPizarra_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contenedores_PizarraId",
                table: "Contenedores",
                column: "PizarraId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_ContenedorId",
                table: "Tarjetas",
                column: "ContenedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PlannerId",
                table: "Usuarios",
                column: "PlannerId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosPizarra_PizarraId1",
                table: "UsuariosPizarra",
                column: "PizarraId1");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosPizarra_UsuarioId",
                table: "UsuariosPizarra",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarjetas");

            migrationBuilder.DropTable(
                name: "UsuariosPizarra");

            migrationBuilder.DropTable(
                name: "Contenedores");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Pizarras");

            migrationBuilder.DropTable(
                name: "Planners");
        }
    }
}
