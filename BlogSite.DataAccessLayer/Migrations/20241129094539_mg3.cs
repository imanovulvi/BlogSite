using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogSite.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "ModifyBy", "ModifyDate", "Name" },
                values: new object[] { new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"), "test", new DateTime(2024, 11, 29, 13, 45, 38, 490, DateTimeKind.Local).AddTicks(3657), false, null, null, "Asp.net" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreateBy", "CreateDate", "IsDelete", "Name", "Path", "Type" },
                values: new object[] { new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"), "test", new DateTime(2024, 11, 29, 13, 45, 38, 490, DateTimeKind.Local).AddTicks(6157), false, "sekil", "/silkel/path", "phg" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreateBy", "CreateDate", "ImageId", "IsDelete", "ModifyBy", "ModifyDate", "Title" },
                values: new object[] { new Guid("273141aa-5cd5-4d3f-82f4-0158dc74feb0"), new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur lobortis rutrum finibus. Fusce ligula nisl, tristique nec quam id, eleifend convallis massa. Fusce nibh leo, porta semper porttitor et, varius ac quam. Suspendisse sed semper metus. Mauris tempus tincidunt ante vel aliquet. Aliquam lobortis ante quis lorem molestie, et ultrices libero posuere. Cras ac augue turpis. Donec dictum purus sem, et venenatis lorem pulvinar in. Duis consequat turpis massa, quis commodo mauris ullamcorper eu. Etiam quis porttitor leo. In rutrum suscipit fringilla. Nullam sit amet velit vitae justo eleifend gravida. Donec sed ex malesuada, viverra risus sit amet, dapibus lorem. In enim enim, volutpat sit amet sapien id, volutpat sodales orci.", "test", new DateTime(2024, 11, 29, 13, 45, 38, 490, DateTimeKind.Local).AddTicks(618), new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"), false, null, null, "basiq 1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("273141aa-5cd5-4d3f-82f4-0158dc74feb0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a1d2850-d938-4e43-ad8e-ef588ec8da48"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("721aa18c-3817-4f2f-a9d8-40be9d5b52cc"));
        }
    }
}
