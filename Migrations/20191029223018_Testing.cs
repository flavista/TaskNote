using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskNote.Migrations
{
    public partial class Testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizarras",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    TipoPizarra = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizarras", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Planners",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planners", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contenedors",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    nombre = table.Column<string>(nullable: true),
                    PizarraID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contenedors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contenedors_Pizarras_PizarraID",
                        column: x => x.PizarraID,
                        principalTable: "Pizarras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estilos",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    font = table.Column<string>(nullable: true),
                    fondo = table.Column<string>(nullable: true),
                    theme = table.Column<string>(nullable: true),
                    PizarraID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estilos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Estilos_Pizarras_PizarraID",
                        column: x => x.PizarraID,
                        principalTable: "Pizarras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    nombreApellido = table.Column<string>(nullable: true),
                    idUsuario = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    nacimiento = table.Column<DateTime>(nullable: false),
                    nombreUsuario = table.Column<string>(nullable: true),
                    contrasenia = table.Column<string>(nullable: true),
                    PizarraID = table.Column<Guid>(nullable: true),
                    PlannerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Usuarios_Pizarras_PizarraID",
                        column: x => x.PizarraID,
                        principalTable: "Pizarras",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_Planners_PlannerID",
                        column: x => x.PlannerID,
                        principalTable: "Planners",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarjetas",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    estiloID = table.Column<Guid>(nullable: true),
                    titulo = table.Column<string>(nullable: true),
                    fechaInicio = table.Column<DateTime>(nullable: false),
                    fechaFin = table.Column<DateTime>(nullable: false),
                    estado = table.Column<int>(nullable: false),
                    comentarios = table.Column<string>(nullable: true),
                    ContenedorID = table.Column<Guid>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    asignadoID = table.Column<Guid>(nullable: true),
                    establecimiento = table.Column<string>(nullable: true),
                    aula = table.Column<string>(nullable: true),
                    Empresa_asignadoID = table.Column<Guid>(nullable: true),
                    centroDeCostos = table.Column<string>(nullable: true),
                    empresa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjetas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tarjetas_Usuarios_asignadoID",
                        column: x => x.asignadoID,
                        principalTable: "Usuarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tarjetas_Usuarios_Empresa_asignadoID",
                        column: x => x.Empresa_asignadoID,
                        principalTable: "Usuarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tarjetas_Contenedors_ContenedorID",
                        column: x => x.ContenedorID,
                        principalTable: "Contenedors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tarjetas_Estilos_estiloID",
                        column: x => x.estiloID,
                        principalTable: "Estilos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contenedors_PizarraID",
                table: "Contenedors",
                column: "PizarraID");

            migrationBuilder.CreateIndex(
                name: "IX_Estilos_PizarraID",
                table: "Estilos",
                column: "PizarraID");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_asignadoID",
                table: "Tarjetas",
                column: "asignadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_Empresa_asignadoID",
                table: "Tarjetas",
                column: "Empresa_asignadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_ContenedorID",
                table: "Tarjetas",
                column: "ContenedorID");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_estiloID",
                table: "Tarjetas",
                column: "estiloID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PizarraID",
                table: "Usuarios",
                column: "PizarraID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PlannerID",
                table: "Usuarios",
                column: "PlannerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarjetas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Contenedors");

            migrationBuilder.DropTable(
                name: "Estilos");

            migrationBuilder.DropTable(
                name: "Planners");

            migrationBuilder.DropTable(
                name: "Pizarras");
        }
    }
}
