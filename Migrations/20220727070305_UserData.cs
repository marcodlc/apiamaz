using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAmaz.Migrations
{
    public partial class UserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("0013cdb4-029b-4eab-b367-41dee6445ea9"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("0bf5e8e7-16fa-4bbc-930e-1d1e7a071879"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("18e84107-27e4-4dc9-bee6-938a7a767059"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("2ba1307c-47d8-46a7-8de0-e00b1a1703e4"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("4be3b904-6295-44e5-9023-d0a7977dc5c0"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("8b401413-e870-4a4f-8183-46cf84184e0a"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("962bdd50-f8ed-4918-a6d9-6e6d93f2ec04"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("b09d5c7c-1232-42ce-ba68-5c03d0e15c6e"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("c474dd60-0038-44f7-87db-26b5a469e8db"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("e0b9fe90-797e-4979-bfb5-0cf47e98e070"));

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    USUARIO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CLAVE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TRABAJADOR = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    APLICACION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ESTADO = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CREADOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHACREACION = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFICADOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FECHAMODIFICACION = table.Column<DateTime>(type: "datetime2", nullable: false, computedColumnSql: "GetUtcDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => new { x.USUARIO, x.CLAVE });
                    table.ForeignKey(
                        name: "FK_USUARIO_TRABAJADOR_TRABAJADOR",
                        column: x => x.TRABAJADOR,
                        principalTable: "TRABAJADOR",
                        principalColumn: "CODIGO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ROL",
                columns: new[] { "CODIGO", "CREADOR", "FECHACREACION", "NOMBRE", "MODIFICADOR" },
                values: new object[,]
                {
                    { new Guid("15f6b842-789c-4bd9-b931-80df31eeed93"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1899), "DESPACHADOR", "admin" },
                    { new Guid("3627aa99-fb25-42d3-8ac5-aeff4f92d0db"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1918), "VENDEDOR FREE", "admin" },
                    { new Guid("4ced3476-e822-48ba-8c25-01e2029d1db1"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1895), "MARKETING", "admin" },
                    { new Guid("5571a1d4-2fa3-4f3d-a6f9-4b97c5753cb0"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1922), "COORDINADOR", "admin" },
                    { new Guid("6ede3d80-167d-4f55-9828-706c1be3e9a9"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1913), "GERENTE COMERCIAL", "admin" },
                    { new Guid("7bc5f5aa-9e6f-4d35-9d7f-536a39bb2595"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1916), "GERENTE GENERAL", "admin" },
                    { new Guid("80b91748-8b5b-4815-a189-ea25ae4c7c83"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1902), "COBRANZA", "admin" },
                    { new Guid("8c8ae9ba-c1a2-45e0-a987-21788d423a74"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1854), "VENDEDOR", "admin" },
                    { new Guid("996d9004-ec56-4c67-9eef-9be6245f0da1"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1873), "ESTILISTA", "admin" },
                    { new Guid("a791db19-3446-4fbe-b40c-8942c453aa15"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1910), "ADMINISTRATIVO", "admin" },
                    { new Guid("dcecaf47-895a-4adb-92b5-0a62336619eb"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1937), "SUPERADMIN", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "00",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "01",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "04",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "06",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "07",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "11",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.InsertData(
                table: "TRABAJADOR",
                columns: new[] { "CODIGO", "CREADOR", "FECHACREACION", "EMAIL", "NOMBRE", "ROL", "MODIFICADOR" },
                values: new object[] { new Guid("dcecaf47-895a-4adb-92b5-0a62336619fc"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 719, DateTimeKind.Local).AddTicks(1168), "marcodlc10@gmail.com", "admin zeus", new Guid("dcecaf47-895a-4adb-92b5-0a62336619eb"), "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_USUARIO_TRABAJADOR",
                table: "USUARIO",
                column: "TRABAJADOR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USUARIO");

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("15f6b842-789c-4bd9-b931-80df31eeed93"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("3627aa99-fb25-42d3-8ac5-aeff4f92d0db"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("4ced3476-e822-48ba-8c25-01e2029d1db1"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("5571a1d4-2fa3-4f3d-a6f9-4b97c5753cb0"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("6ede3d80-167d-4f55-9828-706c1be3e9a9"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("7bc5f5aa-9e6f-4d35-9d7f-536a39bb2595"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("80b91748-8b5b-4815-a189-ea25ae4c7c83"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("8c8ae9ba-c1a2-45e0-a987-21788d423a74"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("996d9004-ec56-4c67-9eef-9be6245f0da1"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("a791db19-3446-4fbe-b40c-8942c453aa15"));

            migrationBuilder.DeleteData(
                table: "TRABAJADOR",
                keyColumn: "CODIGO",
                keyValue: new Guid("dcecaf47-895a-4adb-92b5-0a62336619fc"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("dcecaf47-895a-4adb-92b5-0a62336619eb"));

            migrationBuilder.InsertData(
                table: "ROL",
                columns: new[] { "CODIGO", "CREADOR", "FECHACREACION", "ESTADO", "NOMBRE", "MODIFICADOR" },
                values: new object[,]
                {
                    { new Guid("0013cdb4-029b-4eab-b367-41dee6445ea9"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9815), false, "VENDEDOR FREE", "admin" },
                    { new Guid("0bf5e8e7-16fa-4bbc-930e-1d1e7a071879"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9747), false, "VENDEDOR", "admin" },
                    { new Guid("18e84107-27e4-4dc9-bee6-938a7a767059"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9819), false, "COORDINADOR", "admin" },
                    { new Guid("2ba1307c-47d8-46a7-8de0-e00b1a1703e4"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9776), false, "DESPACHADOR", "admin" },
                    { new Guid("4be3b904-6295-44e5-9023-d0a7977dc5c0"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9773), false, "MARKETING", "admin" },
                    { new Guid("8b401413-e870-4a4f-8183-46cf84184e0a"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9810), false, "GERENTE COMERCIAL", "admin" },
                    { new Guid("962bdd50-f8ed-4918-a6d9-6e6d93f2ec04"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9779), false, "COBRANZA", "admin" },
                    { new Guid("b09d5c7c-1232-42ce-ba68-5c03d0e15c6e"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9812), false, "GERENTE GENERAL", "admin" },
                    { new Guid("c474dd60-0038-44f7-87db-26b5a469e8db"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9807), false, "ADMINISTRATIVO", "admin" },
                    { new Guid("e0b9fe90-797e-4979-bfb5-0cf47e98e070"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9771), false, "ESTILISTA", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "00",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 0, 47, 35, 159, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "01",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 0, 47, 35, 159, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "04",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 0, 47, 35, 159, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "06",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 0, 47, 35, 159, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "07",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 0, 47, 35, 159, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "11",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 0, 47, 35, 159, DateTimeKind.Local).AddTicks(9085));
        }
    }
}
