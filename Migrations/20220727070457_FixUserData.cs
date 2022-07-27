using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAmaz.Migrations
{
    public partial class FixUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("dcecaf47-895a-4adb-92b5-0a62336619eb"),
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.InsertData(
                table: "ROL",
                columns: new[] { "CODIGO", "CREADOR", "FECHACREACION", "NOMBRE", "MODIFICADOR" },
                values: new object[,]
                {
                    { new Guid("4dd3a199-3f3f-4515-9758-d691644012c5"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7113), "COORDINADOR", "admin" },
                    { new Guid("6e96f41d-ae75-471f-9151-1099ecee7bd3"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7073), "MARKETING", "admin" },
                    { new Guid("7b092baa-acdc-47dd-ab74-69a9dc84b2cc"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7107), "GERENTE GENERAL", "admin" },
                    { new Guid("7bd887ab-bdff-4318-af2e-57cef3c703d1"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(6954), "VENDEDOR", "admin" },
                    { new Guid("95ee6172-14ed-480a-b3d3-c2a72d5001cd"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7075), "DESPACHADOR", "admin" },
                    { new Guid("9be1fa1b-a181-4e0b-a54b-0c02e8498a6f"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7070), "ESTILISTA", "admin" },
                    { new Guid("a4cd43c8-1c56-4710-868c-41c7b9b43329"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7078), "COBRANZA", "admin" },
                    { new Guid("a66ae1ba-7121-481a-a171-ae8fc9570078"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7087), "GERENTE COMERCIAL", "admin" },
                    { new Guid("ee737f28-102c-4113-b72f-5f871fb20df5"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7085), "ADMINISTRATIVO", "admin" },
                    { new Guid("ef37dca1-358b-44cb-934e-cdf34a3988a7"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7109), "VENDEDOR FREE", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "00",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 4, 56, 647, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "01",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 4, 56, 647, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "04",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 4, 56, 647, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "06",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 4, 56, 647, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "07",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 4, 56, 647, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "11",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 4, 56, 647, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "TRABAJADOR",
                keyColumn: "CODIGO",
                keyValue: new Guid("dcecaf47-895a-4adb-92b5-0a62336619fc"),
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 4, 56, 647, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.InsertData(
                table: "USUARIO",
                columns: new[] { "CLAVE", "USUARIO", "CREADOR", "FECHACREACION", "APLICACION", "MODIFICADOR", "TRABAJADOR" },
                values: new object[] { "default", "admin", "admin", new DateTime(2022, 7, 27, 2, 4, 56, 648, DateTimeKind.Local).AddTicks(3469), "WebAmaz", "admin", new Guid("dcecaf47-895a-4adb-92b5-0a62336619fc") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("4dd3a199-3f3f-4515-9758-d691644012c5"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("6e96f41d-ae75-471f-9151-1099ecee7bd3"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("7b092baa-acdc-47dd-ab74-69a9dc84b2cc"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("7bd887ab-bdff-4318-af2e-57cef3c703d1"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("95ee6172-14ed-480a-b3d3-c2a72d5001cd"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("9be1fa1b-a181-4e0b-a54b-0c02e8498a6f"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("a4cd43c8-1c56-4710-868c-41c7b9b43329"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("a66ae1ba-7121-481a-a171-ae8fc9570078"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("ee737f28-102c-4113-b72f-5f871fb20df5"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("ef37dca1-358b-44cb-934e-cdf34a3988a7"));

            migrationBuilder.DeleteData(
                table: "USUARIO",
                keyColumns: new[] { "CLAVE", "USUARIO" },
                keyValues: new object[] { "default", "admin" });

            migrationBuilder.UpdateData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("dcecaf47-895a-4adb-92b5-0a62336619eb"),
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.InsertData(
                table: "ROL",
                columns: new[] { "CODIGO", "CREADOR", "FECHACREACION", "ESTADO", "NOMBRE", "MODIFICADOR" },
                values: new object[,]
                {
                    { new Guid("15f6b842-789c-4bd9-b931-80df31eeed93"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1899), false, "DESPACHADOR", "admin" },
                    { new Guid("3627aa99-fb25-42d3-8ac5-aeff4f92d0db"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1918), false, "VENDEDOR FREE", "admin" },
                    { new Guid("4ced3476-e822-48ba-8c25-01e2029d1db1"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1895), false, "MARKETING", "admin" },
                    { new Guid("5571a1d4-2fa3-4f3d-a6f9-4b97c5753cb0"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1922), false, "COORDINADOR", "admin" },
                    { new Guid("6ede3d80-167d-4f55-9828-706c1be3e9a9"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1913), false, "GERENTE COMERCIAL", "admin" },
                    { new Guid("7bc5f5aa-9e6f-4d35-9d7f-536a39bb2595"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1916), false, "GERENTE GENERAL", "admin" },
                    { new Guid("80b91748-8b5b-4815-a189-ea25ae4c7c83"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1902), false, "COBRANZA", "admin" },
                    { new Guid("8c8ae9ba-c1a2-45e0-a987-21788d423a74"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1854), false, "VENDEDOR", "admin" },
                    { new Guid("996d9004-ec56-4c67-9eef-9be6245f0da1"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1873), false, "ESTILISTA", "admin" },
                    { new Guid("a791db19-3446-4fbe-b40c-8942c453aa15"), "admin", new DateTime(2022, 7, 27, 2, 3, 4, 718, DateTimeKind.Local).AddTicks(1910), false, "ADMINISTRATIVO", "admin" }
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

            migrationBuilder.UpdateData(
                table: "TRABAJADOR",
                keyColumn: "CODIGO",
                keyValue: new Guid("dcecaf47-895a-4adb-92b5-0a62336619fc"),
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 3, 4, 719, DateTimeKind.Local).AddTicks(1168));
        }
    }
}
