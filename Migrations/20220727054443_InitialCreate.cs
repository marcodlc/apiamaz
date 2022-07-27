using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAmaz.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ROL",
                columns: table => new
                {
                    CODIGO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOMBRE = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CREADOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHACREACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFICADOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHAMODIFICACION = table.Column<DateTime>(type: "datetime2", nullable: false, computedColumnSql: "GetUtcDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROL", x => x.CODIGO);
                });

            migrationBuilder.CreateTable(
                name: "TIPODOCUMENTOIDENTIDAD",
                columns: table => new
                {
                    TIPODOCUMENTO = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NOMBRE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NOMBRECORTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CREADOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHACREACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFICADOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHAMODIFICACION = table.Column<DateTime>(type: "datetime2", nullable: false, computedColumnSql: "GetUtcDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPODOCUMENTOIDENTIDAD", x => x.TIPODOCUMENTO);
                });

            migrationBuilder.CreateTable(
                name: "TRABAJADOR",
                columns: table => new
                {
                    CODIGO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ROL = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CREADOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHACREACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFICADOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHAMODIFICACION = table.Column<DateTime>(type: "datetime2", nullable: false, computedColumnSql: "GetUtcDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRABAJADOR", x => x.CODIGO);
                    table.ForeignKey(
                        name: "FK_TRABAJADOR_ROL_ROL",
                        column: x => x.ROL,
                        principalTable: "ROL",
                        principalColumn: "CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ROL",
                columns: new[] { "CODIGO", "CREADOR", "FECHACREACION", "NOMBRE", "MODIFICADOR" },
                values: new object[,]
                {
                    { new Guid("0322ed2f-c1d9-441e-b2df-75f94e8f1f79"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(783), "GERENTE COMERCIAL", "admin" },
                    { new Guid("0da303e9-2e0e-4047-a837-705f2c0cabe4"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(744), "VENDEDOR", "admin" },
                    { new Guid("27d8b9cc-90bc-4180-9911-1c217c4df299"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(781), "ADMINISTRATIVO", "admin" },
                    { new Guid("348492bf-244f-4915-b9a2-a3602427245f"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(774), "COBRANZA", "admin" },
                    { new Guid("a39b228d-5bfe-418b-9009-72f907a83e01"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(797), "COORDINADOR", "admin" },
                    { new Guid("b0233e3c-d2a6-4b07-b7c4-83e271579b0c"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(766), "ESTILISTA", "admin" },
                    { new Guid("c24ca63d-cfc0-4b5d-a29f-318100dff246"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(772), "DESPACHADOR", "admin" },
                    { new Guid("cb91795a-d377-4e22-a547-600d0f9b3f6f"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(785), "GERENTE GENERAL", "admin" },
                    { new Guid("e71cc00d-6f7f-4c04-ab42-2b9ea4053b49"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(792), "VENDEDOR FREE", "admin" },
                    { new Guid("f6766044-544b-4dec-9727-22d766078690"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(769), "MARKETING", "admin" }
                });

            migrationBuilder.InsertData(
                table: "TIPODOCUMENTOIDENTIDAD",
                columns: new[] { "TIPODOCUMENTO", "CREADOR", "FECHACREACION", "NOMBRE", "NOMBRECORTO", "MODIFICADOR" },
                values: new object[,]
                {
                    { "00", "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(8159), "OTROS", "OTROS", "admin" },
                    { "01", "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(8169), "LIBRETA ELECTORAL O DNI", "L.E / DNI", "admin" },
                    { "04", "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(8171), "CARNET DE EXTRANJERIA", "CARNET EXT.", "admin" },
                    { "06", "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(8173), "REG. UNICO DE CONTRIBUYENTES", "RUC", "admin" },
                    { "07", "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(8175), "PASAPORTE", "PASAPORTE", "admin" },
                    { "11", "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(8178), "PART. DE NACIMIENTO-IDENTIDAD", "P. NAC.", "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TRABAJADOR_ROL",
                table: "TRABAJADOR",
                column: "ROL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TIPODOCUMENTOIDENTIDAD");

            migrationBuilder.DropTable(
                name: "TRABAJADOR");

            migrationBuilder.DropTable(
                name: "ROL");
        }
    }
}
