using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogSite.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mg4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("273141aa-5cd5-4d3f-82f4-0158dc74feb0"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateBy", "CreateDate", "ImageId", "IsDelete", "ModifyBy", "ModifyDate", "Title" },
                values: new object[,]
                {
                    { new Guid("19a1f93f-3ad6-48ce-90dc-47ab010a1e33"), new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.", "test", new DateTime(2024, 11, 29, 13, 47, 37, 980, DateTimeKind.Local).AddTicks(413), new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"), false, null, null, "basiq 2" },
                    { new Guid("4b9f3e89-eb45-4f73-8a1e-6a011904104a"), new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.", "test", new DateTime(2024, 11, 29, 13, 47, 37, 980, DateTimeKind.Local).AddTicks(379), new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"), false, null, null, "basiq 1" },
                    { new Guid("d3bf148c-e0c2-4e20-bf55-3e74e293baa6"), new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.", "test", new DateTime(2024, 11, 29, 13, 47, 37, 980, DateTimeKind.Local).AddTicks(407), new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"), false, null, null, "basiq 3" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"),
                column: "CreateDate",
                value: new DateTime(2024, 11, 29, 13, 47, 37, 980, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"),
                column: "CreateDate",
                value: new DateTime(2024, 11, 29, 13, 47, 37, 980, DateTimeKind.Local).AddTicks(6452));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("19a1f93f-3ad6-48ce-90dc-47ab010a1e33"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4b9f3e89-eb45-4f73-8a1e-6a011904104a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d3bf148c-e0c2-4e20-bf55-3e74e293baa6"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateBy", "CreateDate", "ImageId", "IsDelete", "ModifyBy", "ModifyDate", "Title" },
                values: new object[] { new Guid("273141aa-5cd5-4d3f-82f4-0158dc74feb0"), new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.", "test", new DateTime(2024, 11, 29, 13, 45, 38, 490, DateTimeKind.Local).AddTicks(618), new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"), false, null, null, "basiq 1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"),
                column: "CreateDate",
                value: new DateTime(2024, 11, 29, 13, 45, 38, 490, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"),
                column: "CreateDate",
                value: new DateTime(2024, 11, 29, 13, 45, 38, 490, DateTimeKind.Local).AddTicks(6157));
        }
    }
}
