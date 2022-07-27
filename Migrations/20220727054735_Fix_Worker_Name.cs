using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAmaz.Migrations
{
    public partial class Fix_Worker_Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("0322ed2f-c1d9-441e-b2df-75f94e8f1f79"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("0da303e9-2e0e-4047-a837-705f2c0cabe4"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("27d8b9cc-90bc-4180-9911-1c217c4df299"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("348492bf-244f-4915-b9a2-a3602427245f"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("a39b228d-5bfe-418b-9009-72f907a83e01"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("b0233e3c-d2a6-4b07-b7c4-83e271579b0c"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("c24ca63d-cfc0-4b5d-a29f-318100dff246"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("cb91795a-d377-4e22-a547-600d0f9b3f6f"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("e71cc00d-6f7f-4c04-ab42-2b9ea4053b49"));

            migrationBuilder.DeleteData(
                table: "ROL",
                keyColumn: "CODIGO",
                keyValue: new Guid("f6766044-544b-4dec-9727-22d766078690"));

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TRABAJADOR",
                newName: "NOMBRE");

            migrationBuilder.AlterColumn<string>(
                name: "NOMBRE",
                table: "TRABAJADOR",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "ROL",
                columns: new[] { "CODIGO", "CREADOR", "FECHACREACION", "NOMBRE", "MODIFICADOR" },
                values: new object[,]
                {
                    { new Guid("0013cdb4-029b-4eab-b367-41dee6445ea9"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9815), "VENDEDOR FREE", "admin" },
                    { new Guid("0bf5e8e7-16fa-4bbc-930e-1d1e7a071879"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9747), "VENDEDOR", "admin" },
                    { new Guid("18e84107-27e4-4dc9-bee6-938a7a767059"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9819), "COORDINADOR", "admin" },
                    { new Guid("2ba1307c-47d8-46a7-8de0-e00b1a1703e4"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9776), "DESPACHADOR", "admin" },
                    { new Guid("4be3b904-6295-44e5-9023-d0a7977dc5c0"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9773), "MARKETING", "admin" },
                    { new Guid("8b401413-e870-4a4f-8183-46cf84184e0a"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9810), "GERENTE COMERCIAL", "admin" },
                    { new Guid("962bdd50-f8ed-4918-a6d9-6e6d93f2ec04"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9779), "COBRANZA", "admin" },
                    { new Guid("b09d5c7c-1232-42ce-ba68-5c03d0e15c6e"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9812), "GERENTE GENERAL", "admin" },
                    { new Guid("c474dd60-0038-44f7-87db-26b5a469e8db"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9807), "ADMINISTRATIVO", "admin" },
                    { new Guid("e0b9fe90-797e-4979-bfb5-0cf47e98e070"), "admin", new DateTime(2022, 7, 27, 0, 47, 35, 158, DateTimeKind.Local).AddTicks(9771), "ESTILISTA", "admin" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "NOMBRE",
                table: "TRABAJADOR",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TRABAJADOR",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "ROL",
                columns: new[] { "CODIGO", "CREADOR", "FECHACREACION", "ESTADO", "NOMBRE", "MODIFICADOR" },
                values: new object[,]
                {
                    { new Guid("0322ed2f-c1d9-441e-b2df-75f94e8f1f79"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(783), false, "GERENTE COMERCIAL", "admin" },
                    { new Guid("0da303e9-2e0e-4047-a837-705f2c0cabe4"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(744), false, "VENDEDOR", "admin" },
                    { new Guid("27d8b9cc-90bc-4180-9911-1c217c4df299"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(781), false, "ADMINISTRATIVO", "admin" },
                    { new Guid("348492bf-244f-4915-b9a2-a3602427245f"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(774), false, "COBRANZA", "admin" },
                    { new Guid("a39b228d-5bfe-418b-9009-72f907a83e01"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(797), false, "COORDINADOR", "admin" },
                    { new Guid("b0233e3c-d2a6-4b07-b7c4-83e271579b0c"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(766), false, "ESTILISTA", "admin" },
                    { new Guid("c24ca63d-cfc0-4b5d-a29f-318100dff246"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(772), false, "DESPACHADOR", "admin" },
                    { new Guid("cb91795a-d377-4e22-a547-600d0f9b3f6f"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(785), false, "GERENTE GENERAL", "admin" },
                    { new Guid("e71cc00d-6f7f-4c04-ab42-2b9ea4053b49"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(792), false, "VENDEDOR FREE", "admin" },
                    { new Guid("f6766044-544b-4dec-9727-22d766078690"), "admin", new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(769), false, "MARKETING", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "00",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "01",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "04",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "06",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "07",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "TIPODOCUMENTOIDENTIDAD",
                keyColumn: "TIPODOCUMENTO",
                keyValue: "11",
                column: "FECHACREACION",
                value: new DateTime(2022, 7, 27, 0, 44, 42, 930, DateTimeKind.Local).AddTicks(8178));
        }
    }
}
