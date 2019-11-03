using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskNote.Migrations
{
    public partial class TaskNote1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contenedors_Pizarras_PizarraID",
                table: "Contenedors");

            migrationBuilder.DropForeignKey(
                name: "FK_Estilos_Pizarras_PizarraID",
                table: "Estilos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Usuarios_asignadoID",
                table: "Tarjetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Usuarios_Empresa_asignadoID",
                table: "Tarjetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Contenedors_ContenedorID",
                table: "Tarjetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Estilos_estiloID",
                table: "Tarjetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Pizarras_PizarraID",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "idUsuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "empresa",
                table: "Tarjetas");

            migrationBuilder.RenameColumn(
                name: "nombreUsuario",
                table: "Usuarios",
                newName: "NombreUsuario");

            migrationBuilder.RenameColumn(
                name: "nombreApellido",
                table: "Usuarios",
                newName: "NombreApellido");

            migrationBuilder.RenameColumn(
                name: "nacimiento",
                table: "Usuarios",
                newName: "Nacimiento");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Usuarios",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "PizarraID",
                table: "Usuarios",
                newName: "PizarraId");

            migrationBuilder.RenameColumn(
                name: "contrasenia",
                table: "Usuarios",
                newName: "Password");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_PizarraID",
                table: "Usuarios",
                newName: "IX_Usuarios_PizarraId");

            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "Tarjetas",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "fechaInicio",
                table: "Tarjetas",
                newName: "FechaInicio");

            migrationBuilder.RenameColumn(
                name: "fechaFin",
                table: "Tarjetas",
                newName: "FechaFin");

            migrationBuilder.RenameColumn(
                name: "estiloID",
                table: "Tarjetas",
                newName: "EstiloID");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Tarjetas",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "comentarios",
                table: "Tarjetas",
                newName: "Comentarios");

            migrationBuilder.RenameColumn(
                name: "centroDeCostos",
                table: "Tarjetas",
                newName: "CentroDeCostos");

            migrationBuilder.RenameColumn(
                name: "Empresa_asignadoID",
                table: "Tarjetas",
                newName: "Empresa_AsignadoID");

            migrationBuilder.RenameColumn(
                name: "establecimiento",
                table: "Tarjetas",
                newName: "Establecimiento");

            migrationBuilder.RenameColumn(
                name: "aula",
                table: "Tarjetas",
                newName: "Aula");

            migrationBuilder.RenameColumn(
                name: "asignadoID",
                table: "Tarjetas",
                newName: "AsignadoID");

            migrationBuilder.RenameIndex(
                name: "IX_Tarjetas_estiloID",
                table: "Tarjetas",
                newName: "IX_Tarjetas_EstiloID");

            migrationBuilder.RenameIndex(
                name: "IX_Tarjetas_Empresa_asignadoID",
                table: "Tarjetas",
                newName: "IX_Tarjetas_Empresa_AsignadoID");

            migrationBuilder.RenameIndex(
                name: "IX_Tarjetas_asignadoID",
                table: "Tarjetas",
                newName: "IX_Tarjetas_AsignadoID");

            migrationBuilder.RenameColumn(
                name: "theme",
                table: "Estilos",
                newName: "Theme");

            migrationBuilder.RenameColumn(
                name: "font",
                table: "Estilos",
                newName: "Font");

            migrationBuilder.RenameColumn(
                name: "fondo",
                table: "Estilos",
                newName: "Fondo");

            migrationBuilder.RenameColumn(
                name: "PizarraID",
                table: "Estilos",
                newName: "PizarraId");

            migrationBuilder.RenameIndex(
                name: "IX_Estilos_PizarraID",
                table: "Estilos",
                newName: "IX_Estilos_PizarraId");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Contenedors",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "PizarraID",
                table: "Contenedors",
                newName: "PizarraId");

            migrationBuilder.RenameIndex(
                name: "IX_Contenedors_PizarraID",
                table: "Contenedors",
                newName: "IX_Contenedors_PizarraId");

            migrationBuilder.AlterColumn<Guid>(
                name: "PizarraId",
                table: "Usuarios",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ContenedorID",
                table: "Tarjetas",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PizarraId",
                table: "Estilos",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PizarraId",
                table: "Contenedors",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contenedors_Pizarras_PizarraId",
                table: "Contenedors",
                column: "PizarraId",
                principalTable: "Pizarras",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estilos_Pizarras_PizarraId",
                table: "Estilos",
                column: "PizarraId",
                principalTable: "Pizarras",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Usuarios_AsignadoID",
                table: "Tarjetas",
                column: "AsignadoID",
                principalTable: "Usuarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Usuarios_Empresa_AsignadoID",
                table: "Tarjetas",
                column: "Empresa_AsignadoID",
                principalTable: "Usuarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Contenedors_ContenedorID",
                table: "Tarjetas",
                column: "ContenedorID",
                principalTable: "Contenedors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Estilos_EstiloID",
                table: "Tarjetas",
                column: "EstiloID",
                principalTable: "Estilos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Pizarras_PizarraId",
                table: "Usuarios",
                column: "PizarraId",
                principalTable: "Pizarras",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contenedors_Pizarras_PizarraId",
                table: "Contenedors");

            migrationBuilder.DropForeignKey(
                name: "FK_Estilos_Pizarras_PizarraId",
                table: "Estilos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Usuarios_AsignadoID",
                table: "Tarjetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Usuarios_Empresa_AsignadoID",
                table: "Tarjetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Contenedors_ContenedorID",
                table: "Tarjetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Estilos_EstiloID",
                table: "Tarjetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Pizarras_PizarraId",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "PizarraId",
                table: "Usuarios",
                newName: "PizarraID");

            migrationBuilder.RenameColumn(
                name: "NombreUsuario",
                table: "Usuarios",
                newName: "nombreUsuario");

            migrationBuilder.RenameColumn(
                name: "NombreApellido",
                table: "Usuarios",
                newName: "nombreApellido");

            migrationBuilder.RenameColumn(
                name: "Nacimiento",
                table: "Usuarios",
                newName: "nacimiento");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuarios",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuarios",
                newName: "contrasenia");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_PizarraId",
                table: "Usuarios",
                newName: "IX_Usuarios_PizarraID");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Tarjetas",
                newName: "titulo");

            migrationBuilder.RenameColumn(
                name: "FechaInicio",
                table: "Tarjetas",
                newName: "fechaInicio");

            migrationBuilder.RenameColumn(
                name: "FechaFin",
                table: "Tarjetas",
                newName: "fechaFin");

            migrationBuilder.RenameColumn(
                name: "EstiloID",
                table: "Tarjetas",
                newName: "estiloID");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Tarjetas",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Comentarios",
                table: "Tarjetas",
                newName: "comentarios");

            migrationBuilder.RenameColumn(
                name: "CentroDeCostos",
                table: "Tarjetas",
                newName: "centroDeCostos");

            migrationBuilder.RenameColumn(
                name: "Empresa_AsignadoID",
                table: "Tarjetas",
                newName: "Empresa_asignadoID");

            migrationBuilder.RenameColumn(
                name: "Establecimiento",
                table: "Tarjetas",
                newName: "establecimiento");

            migrationBuilder.RenameColumn(
                name: "Aula",
                table: "Tarjetas",
                newName: "aula");

            migrationBuilder.RenameColumn(
                name: "AsignadoID",
                table: "Tarjetas",
                newName: "asignadoID");

            migrationBuilder.RenameIndex(
                name: "IX_Tarjetas_EstiloID",
                table: "Tarjetas",
                newName: "IX_Tarjetas_estiloID");

            migrationBuilder.RenameIndex(
                name: "IX_Tarjetas_Empresa_AsignadoID",
                table: "Tarjetas",
                newName: "IX_Tarjetas_Empresa_asignadoID");

            migrationBuilder.RenameIndex(
                name: "IX_Tarjetas_AsignadoID",
                table: "Tarjetas",
                newName: "IX_Tarjetas_asignadoID");

            migrationBuilder.RenameColumn(
                name: "Theme",
                table: "Estilos",
                newName: "theme");

            migrationBuilder.RenameColumn(
                name: "PizarraId",
                table: "Estilos",
                newName: "PizarraID");

            migrationBuilder.RenameColumn(
                name: "Font",
                table: "Estilos",
                newName: "font");

            migrationBuilder.RenameColumn(
                name: "Fondo",
                table: "Estilos",
                newName: "fondo");

            migrationBuilder.RenameIndex(
                name: "IX_Estilos_PizarraId",
                table: "Estilos",
                newName: "IX_Estilos_PizarraID");

            migrationBuilder.RenameColumn(
                name: "PizarraId",
                table: "Contenedors",
                newName: "PizarraID");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Contenedors",
                newName: "nombre");

            migrationBuilder.RenameIndex(
                name: "IX_Contenedors_PizarraId",
                table: "Contenedors",
                newName: "IX_Contenedors_PizarraID");

            migrationBuilder.AlterColumn<Guid>(
                name: "PizarraID",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<int>(
                name: "idUsuario",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "ContenedorID",
                table: "Tarjetas",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<string>(
                name: "empresa",
                table: "Tarjetas",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PizarraID",
                table: "Estilos",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "PizarraID",
                table: "Contenedors",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Contenedors_Pizarras_PizarraID",
                table: "Contenedors",
                column: "PizarraID",
                principalTable: "Pizarras",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estilos_Pizarras_PizarraID",
                table: "Estilos",
                column: "PizarraID",
                principalTable: "Pizarras",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Usuarios_asignadoID",
                table: "Tarjetas",
                column: "asignadoID",
                principalTable: "Usuarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Usuarios_Empresa_asignadoID",
                table: "Tarjetas",
                column: "Empresa_asignadoID",
                principalTable: "Usuarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Contenedors_ContenedorID",
                table: "Tarjetas",
                column: "ContenedorID",
                principalTable: "Contenedors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Estilos_estiloID",
                table: "Tarjetas",
                column: "estiloID",
                principalTable: "Estilos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Pizarras_PizarraID",
                table: "Usuarios",
                column: "PizarraID",
                principalTable: "Pizarras",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
