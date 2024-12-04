using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogSite.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0f8e5818-0f1c-4d82-9d8d-a88c90682fa6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3a9ab361-3e2b-4357-8e16-3366911ffe56"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6cede953-1e2e-4ef6-8d8a-a4141ebec19c"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("52061fef-dd79-4a7a-aeef-94fad1f19047"), null, "Admin", "ADMIN" },
                    { new Guid("6c38ad42-985a-4a11-bec8-d0d8d6c61a85"), null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("72ca5ec3-35ca-4b66-b7f4-3630816c0717"), 0, "0f5ad61b-a3b6-4d9b-b202-7f85697b52f5", "ter@gmail.com", true, "Terlan Imanov", false, null, null, null, "1234", null, false, null, false, "Terlan" },
                    { new Guid("f4b33e74-60ae-4e55-8762-05b636ae0da5"), 0, "48d72eaf-d7b3-4b12-adb5-d1ba52d8354e", "imanov@gmail.com", true, "ULvi Imanov", false, null, null, null, "1234", null, false, null, false, "Ulvi" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"),
                column: "CreateDate",
                value: new DateTime(2024, 12, 4, 13, 23, 35, 423, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"),
                column: "CreateDate",
                value: new DateTime(2024, 12, 4, 13, 23, 35, 424, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateBy", "CreateDate", "ImageId", "IsDelete", "ModifyBy", "ModifyDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("05faa4b6-8935-4acb-88f9-9df35579a25e"), new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.", "test", new DateTime(2024, 12, 4, 13, 23, 35, 423, DateTimeKind.Local).AddTicks(6291), new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"), false, null, null, "basiq 1", new Guid("f4b33e74-60ae-4e55-8762-05b636ae0da5") },
                    { new Guid("090c57b1-ca20-4d5c-bcf1-bdd8b8f204bd"), new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.", "test", new DateTime(2024, 12, 4, 13, 23, 35, 423, DateTimeKind.Local).AddTicks(6417), new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"), false, null, null, "basiq 2", new Guid("72ca5ec3-35ca-4b66-b7f4-3630816c0717") },
                    { new Guid("b922ab9b-e580-432a-88ef-cb0c4bef256b"), new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.", "test", new DateTime(2024, 12, 4, 13, 23, 35, 423, DateTimeKind.Local).AddTicks(6387), new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"), false, null, null, "basiq 3", new Guid("f4b33e74-60ae-4e55-8762-05b636ae0da5") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6c38ad42-985a-4a11-bec8-d0d8d6c61a85"), new Guid("72ca5ec3-35ca-4b66-b7f4-3630816c0717") },
                    { new Guid("52061fef-dd79-4a7a-aeef-94fad1f19047"), new Guid("f4b33e74-60ae-4e55-8762-05b636ae0da5") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AspNetUsers_UserId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_UserId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("05faa4b6-8935-4acb-88f9-9df35579a25e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("090c57b1-ca20-4d5c-bcf1-bdd8b8f204bd"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b922ab9b-e580-432a-88ef-cb0c4bef256b"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6c38ad42-985a-4a11-bec8-d0d8d6c61a85"), new Guid("72ca5ec3-35ca-4b66-b7f4-3630816c0717") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("52061fef-dd79-4a7a-aeef-94fad1f19047"), new Guid("f4b33e74-60ae-4e55-8762-05b636ae0da5") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("52061fef-dd79-4a7a-aeef-94fad1f19047"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6c38ad42-985a-4a11-bec8-d0d8d6c61a85"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("72ca5ec3-35ca-4b66-b7f4-3630816c0717"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4b33e74-60ae-4e55-8762-05b636ae0da5"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateBy", "CreateDate", "ImageId", "IsDelete", "ModifyBy", "ModifyDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0f8e5818-0f1c-4d82-9d8d-a88c90682fa6"), new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.", "test", new DateTime(2024, 12, 3, 14, 26, 0, 604, DateTimeKind.Local).AddTicks(1074), new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"), false, null, null, "basiq 2" },
                    { new Guid("3a9ab361-3e2b-4357-8e16-3366911ffe56"), new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.", "test", new DateTime(2024, 12, 3, 14, 26, 0, 604, DateTimeKind.Local).AddTicks(1020), new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"), false, null, null, "basiq 1" },
                    { new Guid("6cede953-1e2e-4ef6-8d8a-a4141ebec19c"), new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.", "test", new DateTime(2024, 12, 3, 14, 26, 0, 604, DateTimeKind.Local).AddTicks(1069), new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"), false, null, null, "basiq 3" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"),
                column: "CreateDate",
                value: new DateTime(2024, 12, 3, 14, 26, 0, 604, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"),
                column: "CreateDate",
                value: new DateTime(2024, 12, 3, 14, 26, 0, 604, DateTimeKind.Local).AddTicks(5086));
        }
    }
}
