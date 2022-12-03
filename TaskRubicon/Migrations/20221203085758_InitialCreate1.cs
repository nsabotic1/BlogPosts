using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskRubicon.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Body", "Description", "Slug", "Title", "createdAt", "updatedAt" },
                values: new object[,]
                {
                    { 1, "The app is simple to use, and will help you decide on your best furniture fit.", "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", "augmented-reality-ios-application", "Augmented Reality iOS Application", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4304), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4305) },
                    { 2, "The app is simple to use, and will help you decide on your best furniture fit.", "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.", "augmented-reality-ios-application-2", "Augmented Reality iOS Application 2", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4328), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4328) },
                    { 3, "The app is simple to use.", "Rubicon Software Development and Gazzda furniture are proud to launch an java app.", "java-application", "Java application", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4337), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4337) },
                    { 4, "The app is suitable for beginners.", "Faculty of Electrical Engineering Sarajevo is proud to launch an console app.", "console-application-for-students", "Console application for students!", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4345), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4345) },
                    { 5, "The app is very interesting.", "A young student is proud to launch an android app.", "android-application", "Android application", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4354), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4354) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BlogPostId", "Body", "createdAt", "updatedAt" },
                values: new object[,]
                {
                    { 1, 1, "Great blog.", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4473), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4474) },
                    { 2, 1, "Very nice blog", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4484), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4484) },
                    { 3, 1, "Wonderful blog.", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4491), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4492) },
                    { 4, 2, "Woow", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4649), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4649) },
                    { 5, 3, "Amazing", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4676), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4676) },
                    { 6, 3, "I love it!", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4685), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4686) },
                    { 7, 4, "The best app ever!", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4693), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4693) },
                    { 8, 4, "I don't like it!", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4701), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4701) },
                    { 9, 5, "I don't like it!", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4708), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4708) },
                    { 10, 5, "One of the best apps i ever had", new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4716), new DateTime(2022, 12, 3, 8, 57, 57, 993, DateTimeKind.Utc).AddTicks(4716) }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "BlogPostId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "iOS" },
                    { 2, 1, "AR" },
                    { 3, 2, "Gazzda" },
                    { 4, 2, "AR" },
                    { 5, 2, "iOS" },
                    { 6, 3, "Java" },
                    { 7, 3, "React" },
                    { 8, 4, "React" },
                    { 9, 4, "ASP.NET" },
                    { 10, 4, "Postman" },
                    { 11, 5, "Kotlin" },
                    { 12, 5, "Flutter" },
                    { 13, 5, "Postman" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
