using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskRubicon.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3253), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3274), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3282), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3289), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3297), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3397), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3406), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3414), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3420), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3426), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3434), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3470), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3478), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3484), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3492), new DateTime(2022, 12, 3, 9, 30, 40, 717, DateTimeKind.Utc).AddTicks(3492) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4304), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4328), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4337), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4345), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4354), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4473), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4484), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4491), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4649), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4676), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4685), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4693), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4701), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4708), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4716), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4716) });
        }
    }
}
