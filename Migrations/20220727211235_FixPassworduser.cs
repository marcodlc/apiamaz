using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAmaz.Migrations
{
    public partial class FixPassworduser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2022, 7, 27, 16, 12, 34, 958, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.InsertData(
                table: "ROL",
                columns: new[] { "CODIGO", "CREADOR", "FECHACREACION", "NOMBRE", "MODIFICADOR" },
                values: new object[,]
                {
                    { new Guid("1144b0d8-aa02-4ed0-a3a0-99a53ea84545"), "admin", new DateTime(2022, 7, 27, 16, 12, 34, 958, DateTimeKind.Local).AddTicks(6960), "GERENTE GENERAL", "admin" },
                    { new Guid("2e22733d-9bc3-461e-b377-a14b585d0224"), "admin", new DateTime(2022, 7, 27, 16, 12, 34, 958, DateTimeKind.Local).AddTicks(6954), "ADMINISTRATIVO", "admin" },
                    { new Guid("3427e015-e768-493b-bf2b-c5949791b2d2"), "admin", new DateTime(2022, 7, 27, 16, 12, 34, 958, DateTimeKind.Local).AddTicks(6957), "GERENTE COMERCIAL", "admin" },
                    { new Guid("557e3808-e5f4-4f18-b6f4-a8d219147cfa"), "admin", new DateTime(2022, 7, 27, 16, 12, 34, 958, DateTimeKind.Local).AddTicks(6919), "ESTILISTA", "admin" },
                    { new Guid("5f1e5987-ef90-4d59-9192-f713d14e7ae7"), "admin", new DateTime(2022, 7, 27, 16, 12, 34, 958, DateTimeKind.Local).AddTicks(6926), "DESPACHADOR", "admin" },
                    { new Guid("67137570-c0ab-4598-8718-88a10112adb1"), "admin", new DateTime(2022, 7, 27, 16, 12, 34, 958, DateTimeKind.Local).AddTicks(6929), "COBRANZA", "admin" },
                    { new Guid("6e4e0b71-c420-4447-aaa7-e9b2ed729d60"), "admin", new DateTime(2022, 7, 27, 16, 12, 34, 958, DateTimeKind.Local).AddTicks(6901), "VENDEDOR", "admin" },
                    { new Guid("9d476a12-a564-406a-a81c-45e8a5cc6456"), "admin", new DateTime(2022, 7, 27, 16, 12, 34, 958, DateTimeKind.Local).AddTicks(6924), "MARKETING", "admin" },
                    { new Guid("dc216ded-9d25-46a7-aa73-74c2005f9c10"), "admin", new DateTime(2022, 7, 27, 16, 12, 34, 958, DateTimeKind.Local).AddTicks(6963), "VENDEDOR FREE", "admin" },
                    { new Guid("df581d46-7b01-4a2a-82c9-ba4791558bb1"), "admin", new DateTime(2022, 7, 27, 16, 12, 34, 958, DateTimeKind.Local).AddTicks(6966), "COORDINADOR", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "00",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 16, 12, 34, 959, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "01",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 16, 12, 34, 959, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "04",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 16, 12, 34, 959, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "06",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 16, 12, 34, 959, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "07",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 16, 12, 34, 959, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "11",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 16, 12, 34, 959, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "TRABAJADOR",
                keyColumn: "CODIGO",
                keyValue: new Guid("dcecaf47-895a-4adb-92b5-0a62336619fc"),
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 16, 12, 34, 959, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.InsertData(
                table: "USUARIO",
                columns: new[] { "CLAVE", "USUARIO", "CREADOR", "FECHACREACION", "APLICACION", "MODIFICADOR", "TRABAJADOR" },
                values: new object[] { "nFwdsS1uqww=", "admin", "admin", new DateTime(2022, 7, 27, 16, 12, 34, 960, DateTimeKind.Local).AddTicks(5451), "WebAmaz", "admin", new Guid("dcecaf47-895a-4adb-92b5-0a62336619fc") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("1144b0d8-aa02-4ed0-a3a0-99a53ea84545"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("2e22733d-9bc3-461e-b377-a14b585d0224"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("3427e015-e768-493b-bf2b-c5949791b2d2"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("557e3808-e5f4-4f18-b6f4-a8d219147cfa"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("5f1e5987-ef90-4d59-9192-f713d14e7ae7"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("67137570-c0ab-4598-8718-88a10112adb1"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("6e4e0b71-c420-4447-aaa7-e9b2ed729d60"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("9d476a12-a564-406a-a81c-45e8a5cc6456"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("dc216ded-9d25-46a7-aa73-74c2005f9c10"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("df581d46-7b01-4a2a-82c9-ba4791558bb1"));

            migrationBuilder.DeleteData(
                table: "USUARIO",
                keyColumns: new[] { "CLAVE", "USUARIO" },
                keyValues: new object[] { "nFwdsS1uqww=", "admin" });

            migrationBuilder.UpdateData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("dcecaf47-895a-4adb-92b5-0a62336619eb"),
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.InsertData(
                table: "ROL",
                columns: new[] { "CODIGO", "CREADOR", "FECHACREACION", "ESTADO", "NOMBRE", "MODIFICADOR" },
                values: new object[,]
                {
                    { new Guid("4dd3a199-3f3f-4515-9758-d691644012c5"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7113), false, "COORDINADOR", "admin" },
                    { new Guid("6e96f41d-ae75-471f-9151-1099ecee7bd3"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7073), false, "MARKETING", "admin" },
                    { new Guid("7b092baa-acdc-47dd-ab74-69a9dc84b2cc"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7107), false, "GERENTE GENERAL", "admin" },
                    { new Guid("7bd887ab-bdff-4318-af2e-57cef3c703d1"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(6954), false, "VENDEDOR", "admin" },
                    { new Guid("95ee6172-14ed-480a-b3d3-c2a72d5001cd"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7075), false, "DESPACHADOR", "admin" },
                    { new Guid("9be1fa1b-a181-4e0b-a54b-0c02e8498a6f"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7070), false, "ESTILISTA", "admin" },
                    { new Guid("a4cd43c8-1c56-4710-868c-41c7b9b43329"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7078), false, "COBRANZA", "admin" },
                    { new Guid("a66ae1ba-7121-481a-a171-ae8fc9570078"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7087), false, "GERENTE COMERCIAL", "admin" },
                    { new Guid("ee737f28-102c-4113-b72f-5f871fb20df5"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7085), false, "ADMINISTRATIVO", "admin" },
                    { new Guid("ef37dca1-358b-44cb-934e-cdf34a3988a7"), "admin", new DateTime(2022, 7, 27, 2, 4, 56, 646, DateTimeKind.Local).AddTicks(7109), false, "VENDEDOR FREE", "admin" }
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
                columns: new[] { "CLAVE", "USUARIO", "CREADOR", "FECHACREACION", "ESTADO", "APLICACION", "MODIFICADOR", "TRABAJADOR" },
                values: new object[] { "default", "admin", "admin", new DateTime(2022, 7, 27, 2, 4, 56, 648, DateTimeKind.Local).AddTicks(3469), false, "WebAmaz", "admin", new Guid("dcecaf47-895a-4adb-92b5-0a62336619fc") });
        }
    }
}
