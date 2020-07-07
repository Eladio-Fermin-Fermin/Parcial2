using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial2.Migrations
{
    public partial class Migracion_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    ProyectoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.ProyectoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoTarea",
                columns: table => new
                {
                    TareaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipodeTarea = table.Column<string>(nullable: true),
                    ProyectoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTarea", x => x.TareaId);
                    table.ForeignKey(
                        name: "FK_TipoTarea_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "ProyectoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Proyectos",
                columns: new[] { "ProyectoId", "Descripcion", "Fecha" },
                values: new object[] { 1, "Server programado en LUA para la instalacion de scrip.", new DateTime(2020, 7, 6, 23, 38, 36, 959, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.InsertData(
                table: "Proyectos",
                columns: new[] { "ProyectoId", "Descripcion", "Fecha" },
                values: new object[] { 2, "Realizar un analisis de la empresa.", new DateTime(2020, 7, 6, 23, 38, 36, 959, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.InsertData(
                table: "Proyectos",
                columns: new[] { "ProyectoId", "Descripcion", "Fecha" },
                values: new object[] { 3, "Diseñar un modelo en UML.", new DateTime(2020, 7, 6, 23, 38, 36, 959, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.InsertData(
                table: "TipoTarea",
                columns: new[] { "TareaId", "ProyectoId", "TipodeTarea" },
                values: new object[] { 1, null, "importantes" });

            migrationBuilder.InsertData(
                table: "TipoTarea",
                columns: new[] { "TareaId", "ProyectoId", "TipodeTarea" },
                values: new object[] { 2, null, "Análisis" });

            migrationBuilder.InsertData(
                table: "TipoTarea",
                columns: new[] { "TareaId", "ProyectoId", "TipodeTarea" },
                values: new object[] { 3, null, "Diseño" });

            migrationBuilder.InsertData(
                table: "TipoTarea",
                columns: new[] { "TareaId", "ProyectoId", "TipodeTarea" },
                values: new object[] { 4, null, "Prueba" });

            migrationBuilder.InsertData(
                table: "TipoTarea",
                columns: new[] { "TareaId", "ProyectoId", "TipodeTarea" },
                values: new object[] { 5, null, "Programacion" });

            migrationBuilder.CreateIndex(
                name: "IX_TipoTarea_ProyectoId",
                table: "TipoTarea",
                column: "ProyectoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoTarea");

            migrationBuilder.DropTable(
                name: "Proyectos");
        }
    }
}
