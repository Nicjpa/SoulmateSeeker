﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoulmateSeeker.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KnownAs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastActive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LookingFor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Interests = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "City", "Country", "Created", "DateOfBirth", "Gender", "Interests", "Introduction", "KnownAs", "LastActive", "LookingFor", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[,]
                {
                    { 1, "Greenbush", "Martinique", new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", "I am interesed in blablabla", "IntroductionBlablabla", "liza", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 204, 0, 223, 178, 201, 208, 26, 101, 234, 39, 185, 45, 169, 181, 176, 244, 64, 132, 252, 227, 5, 214, 243, 112, 136, 222, 154, 229, 189, 54, 20, 121, 198, 76, 43, 252, 4, 120, 193, 92, 83, 50, 6, 126, 238, 27, 223, 35, 31, 23, 64, 214, 10, 125, 212, 98, 24, 45, 151, 6, 25, 101, 63, 25 }, new byte[] { 59, 216, 166, 8, 104, 122, 161, 215, 165, 10, 195, 184, 159, 132, 252, 38, 138, 202, 138, 177, 128, 163, 121, 41, 162, 54, 168, 224, 146, 206, 75, 135, 179, 252, 78, 148, 23, 248, 110, 125, 33, 19, 75, 95, 110, 116, 25, 159, 10, 207, 38, 93, 76, 106, 30, 66, 222, 83, 152, 183, 5, 207, 2, 61, 134, 91, 172, 231, 102, 82, 141, 105, 108, 251, 152, 12, 161, 218, 117, 191, 205, 55, 152, 19, 56, 13, 147, 235, 47, 62, 80, 148, 253, 136, 78, 248, 144, 20, 114, 107, 230, 173, 71, 117, 192, 34, 97, 74, 242, 206, 238, 82, 155, 30, 97, 151, 175, 228, 190, 163, 225, 185, 170, 195, 183, 59, 192, 81 }, "liza" },
                    { 2, "Celeryville", "Grenada", new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", "I am interesed in blablabla", "IntroductionBlablabla", "karen", new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 161, 242, 95, 213, 113, 107, 252, 134, 117, 178, 13, 254, 250, 122, 88, 108, 45, 125, 82, 78, 220, 114, 96, 73, 171, 124, 72, 210, 24, 151, 207, 49, 236, 154, 170, 205, 85, 27, 151, 141, 221, 205, 55, 122, 206, 178, 186, 142, 238, 222, 70, 65, 197, 255, 65, 119, 188, 102, 49, 80, 61, 21, 30, 160 }, new byte[] { 177, 77, 253, 223, 152, 76, 248, 162, 168, 143, 202, 222, 71, 187, 51, 152, 100, 230, 69, 18, 141, 41, 119, 14, 151, 72, 214, 252, 249, 134, 85, 248, 40, 60, 75, 160, 235, 166, 103, 170, 167, 53, 155, 97, 67, 88, 157, 230, 23, 125, 166, 164, 108, 102, 35, 250, 233, 150, 116, 202, 72, 40, 168, 166, 158, 49, 99, 155, 236, 33, 25, 59, 125, 102, 175, 73, 106, 173, 102, 218, 180, 88, 147, 10, 25, 7, 40, 105, 91, 48, 215, 122, 70, 65, 198, 74, 53, 99, 149, 128, 147, 216, 249, 97, 90, 154, 41, 3, 109, 70, 243, 44, 4, 236, 167, 215, 141, 227, 236, 117, 251, 141, 81, 45, 214, 119, 164, 85 }, "karen" },
                    { 3, "Rosewood", "Svalbard and Jan Mayen Islands", new DateTime(2019, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", "I am interesed in blablabla", "IntroductionBlablabla", "margo", new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 255, 62, 15, 168, 150, 141, 242, 159, 101, 169, 38, 124, 181, 195, 99, 157, 34, 240, 227, 68, 94, 140, 79, 84, 68, 126, 134, 173, 75, 97, 135, 74, 158, 201, 59, 123, 192, 51, 194, 179, 71, 228, 117, 79, 132, 89, 32, 193, 54, 226, 127, 194, 125, 148, 8, 219, 19, 63, 223, 109, 14, 144, 205, 144 }, new byte[] { 229, 229, 112, 144, 112, 155, 77, 41, 126, 21, 42, 201, 74, 250, 173, 29, 90, 72, 29, 211, 230, 88, 30, 246, 248, 112, 109, 191, 79, 165, 163, 103, 22, 211, 168, 100, 128, 50, 176, 126, 45, 241, 127, 131, 10, 50, 21, 65, 89, 33, 104, 92, 28, 128, 38, 151, 218, 174, 255, 179, 162, 216, 84, 153, 141, 220, 135, 35, 117, 93, 28, 144, 201, 105, 86, 184, 88, 13, 123, 139, 251, 43, 151, 7, 45, 97, 238, 200, 235, 194, 68, 87, 234, 150, 9, 16, 162, 24, 64, 250, 159, 169, 217, 128, 252, 56, 163, 252, 3, 52, 82, 187, 216, 196, 56, 100, 15, 192, 93, 149, 249, 255, 169, 43, 169, 213, 30, 163 }, "margo" },
                    { 4, "Orviston", "Zimbabwe", new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", "I am interesed in blablabla", "IntroductionBlablabla", "lois", new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 30, 92, 149, 17, 200, 5, 3, 125, 224, 24, 172, 244, 78, 102, 197, 236, 186, 82, 165, 184, 186, 143, 17, 123, 110, 115, 249, 39, 80, 169, 119, 43, 25, 164, 235, 235, 80, 161, 69, 47, 120, 139, 200, 178, 62, 232, 211, 1, 213, 47, 93, 213, 133, 185, 130, 200, 123, 67, 184, 193, 197, 208, 50, 243 }, new byte[] { 231, 126, 163, 37, 119, 214, 31, 204, 46, 201, 172, 14, 53, 155, 79, 177, 27, 148, 74, 239, 105, 2, 81, 204, 77, 203, 197, 225, 90, 116, 115, 114, 37, 233, 119, 53, 238, 116, 30, 237, 111, 135, 174, 145, 20, 231, 189, 158, 96, 193, 15, 30, 113, 172, 176, 126, 146, 138, 96, 85, 167, 172, 240, 135, 253, 165, 222, 123, 53, 164, 88, 198, 17, 3, 122, 107, 232, 70, 235, 122, 242, 26, 66, 73, 229, 212, 188, 220, 6, 34, 135, 160, 255, 107, 155, 160, 249, 34, 203, 208, 149, 225, 91, 207, 192, 219, 176, 66, 213, 134, 178, 255, 238, 143, 162, 68, 213, 59, 204, 250, 87, 140, 219, 164, 23, 26, 108, 69 }, "lois" },
                    { 5, "Germanton", "Antigua and Barbuda", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", "I am interesed in blablabla", "IntroductionBlablabla", "ruthie", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 136, 201, 223, 217, 186, 123, 50, 254, 129, 55, 39, 248, 47, 109, 0, 92, 168, 94, 202, 195, 162, 58, 72, 31, 62, 165, 205, 183, 167, 59, 54, 137, 74, 57, 156, 155, 128, 233, 68, 186, 212, 224, 106, 142, 17, 219, 123, 194, 247, 23, 119, 45, 105, 220, 201, 45, 93, 219, 216, 3, 196, 152, 184, 192 }, new byte[] { 232, 125, 95, 185, 114, 26, 163, 125, 52, 184, 249, 24, 63, 158, 82, 234, 156, 2, 225, 129, 189, 123, 60, 81, 157, 75, 111, 186, 150, 94, 146, 127, 75, 191, 155, 161, 140, 170, 119, 187, 107, 86, 26, 141, 249, 126, 73, 219, 94, 24, 176, 182, 251, 165, 6, 59, 88, 218, 252, 211, 230, 43, 122, 219, 224, 244, 217, 155, 149, 12, 131, 13, 145, 64, 161, 17, 122, 214, 172, 50, 148, 24, 193, 123, 49, 208, 227, 109, 230, 178, 179, 244, 4, 43, 255, 201, 30, 199, 150, 250, 110, 208, 118, 80, 239, 156, 253, 68, 223, 52, 190, 225, 182, 116, 204, 51, 87, 164, 15, 14, 147, 3, 251, 50, 197, 101, 49, 26 }, "ruthie" },
                    { 6, "Cliff", "British Indian Ocean Territory", new DateTime(2019, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "I am interesed in blablabla", "IntroductionBlablabla", "todd", new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 236, 255, 212, 40, 64, 201, 120, 77, 9, 42, 100, 219, 227, 253, 118, 14, 213, 185, 73, 144, 45, 143, 170, 132, 2, 160, 130, 150, 4, 222, 190, 216, 114, 8, 28, 167, 34, 187, 31, 167, 227, 108, 187, 168, 61, 237, 122, 36, 6, 202, 90, 119, 112, 4, 105, 247, 80, 235, 157, 0, 182, 240, 116, 75 }, new byte[] { 255, 10, 59, 170, 164, 63, 49, 236, 169, 133, 172, 56, 130, 67, 133, 73, 177, 171, 243, 35, 68, 16, 219, 182, 147, 140, 77, 206, 232, 100, 130, 217, 200, 241, 198, 164, 237, 128, 174, 205, 37, 20, 27, 121, 117, 144, 97, 87, 87, 202, 3, 39, 191, 233, 148, 171, 248, 91, 235, 166, 19, 23, 238, 46, 84, 137, 166, 173, 3, 61, 92, 76, 123, 89, 133, 67, 233, 232, 195, 84, 88, 122, 80, 245, 96, 43, 220, 198, 43, 114, 230, 162, 194, 102, 254, 217, 54, 230, 56, 1, 127, 225, 67, 84, 217, 155, 21, 234, 91, 79, 213, 74, 20, 237, 171, 15, 142, 150, 136, 180, 234, 95, 133, 174, 37, 127, 142, 55 }, "todd" },
                    { 7, "Welda", "Christmas Island", new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "I am interesed in blablabla", "IntroductionBlablabla", "porter", new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 90, 177, 178, 154, 15, 15, 244, 107, 86, 209, 46, 31, 95, 248, 217, 232, 175, 130, 208, 131, 102, 44, 52, 176, 233, 224, 56, 131, 19, 235, 16, 254, 79, 95, 15, 14, 59, 44, 37, 145, 4, 28, 166, 244, 32, 219, 118, 35, 72, 61, 223, 70, 58, 25, 199, 12, 196, 144, 239, 156, 150, 72, 131, 4 }, new byte[] { 139, 132, 1, 47, 89, 253, 57, 68, 160, 250, 165, 71, 219, 223, 214, 231, 15, 127, 53, 183, 56, 181, 48, 59, 85, 62, 171, 125, 221, 149, 185, 33, 44, 162, 225, 159, 168, 233, 36, 17, 96, 67, 208, 165, 225, 177, 163, 156, 54, 105, 89, 159, 71, 249, 141, 194, 164, 134, 190, 33, 109, 210, 202, 150, 22, 5, 149, 118, 87, 214, 178, 108, 0, 92, 255, 121, 62, 192, 106, 217, 116, 195, 181, 192, 196, 206, 113, 197, 156, 69, 67, 155, 50, 130, 5, 35, 250, 216, 56, 202, 138, 158, 49, 145, 117, 41, 252, 220, 74, 43, 39, 146, 121, 132, 158, 23, 138, 253, 217, 172, 211, 151, 33, 12, 74, 58, 92, 197 }, "porter" },
                    { 8, "Calrence", "Burkina Faso", new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "I am interesed in blablabla", "IntroductionBlablabla", "mayo", new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 238, 251, 54, 250, 46, 94, 10, 145, 134, 76, 65, 249, 200, 179, 250, 3, 87, 163, 226, 139, 86, 179, 209, 142, 193, 70, 214, 183, 151, 203, 201, 215, 150, 193, 142, 44, 88, 23, 98, 197, 228, 233, 153, 120, 120, 93, 101, 91, 114, 217, 187, 200, 130, 184, 81, 93, 103, 114, 170, 53, 202, 171, 52, 210 }, new byte[] { 135, 236, 183, 16, 110, 33, 73, 189, 0, 147, 137, 25, 12, 97, 14, 225, 253, 80, 120, 35, 47, 88, 211, 202, 47, 253, 189, 203, 122, 134, 53, 161, 133, 195, 83, 81, 81, 171, 88, 133, 167, 14, 213, 63, 12, 240, 163, 250, 252, 3, 212, 36, 169, 242, 78, 42, 205, 156, 234, 42, 101, 97, 85, 107, 218, 238, 123, 206, 113, 139, 110, 144, 133, 122, 210, 244, 236, 74, 153, 148, 106, 87, 154, 37, 8, 1, 143, 100, 153, 201, 16, 49, 23, 35, 229, 72, 239, 229, 80, 230, 13, 2, 139, 15, 114, 192, 211, 166, 217, 117, 12, 90, 149, 195, 120, 198, 32, 91, 127, 216, 75, 45, 183, 111, 112, 245, 201, 167 }, "mayo" },
                    { 9, "Herald", "Poland", new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "I am interesed in blablabla", "IntroductionBlablabla", "skinner", new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 182, 15, 176, 178, 91, 85, 160, 144, 176, 224, 127, 104, 171, 197, 200, 44, 189, 136, 141, 166, 176, 60, 51, 252, 197, 192, 191, 151, 225, 102, 212, 108, 214, 106, 88, 29, 97, 63, 203, 223, 53, 178, 69, 4, 220, 240, 230, 163, 225, 237, 180, 190, 16, 202, 230, 120, 251, 249, 132, 175, 46, 177, 204, 104 }, new byte[] { 113, 208, 12, 146, 171, 75, 203, 229, 148, 194, 30, 28, 241, 144, 35, 36, 224, 113, 126, 163, 183, 249, 214, 21, 193, 142, 207, 185, 37, 212, 217, 39, 113, 69, 111, 246, 95, 73, 131, 156, 177, 250, 137, 145, 93, 100, 147, 23, 97, 72, 3, 133, 98, 114, 196, 214, 119, 120, 231, 29, 97, 88, 193, 66, 71, 84, 73, 184, 65, 10, 98, 26, 170, 223, 184, 73, 132, 7, 131, 215, 88, 178, 119, 60, 134, 241, 50, 214, 204, 24, 227, 43, 226, 196, 185, 188, 125, 191, 146, 141, 43, 168, 154, 151, 53, 121, 177, 170, 38, 43, 43, 39, 239, 28, 73, 85, 38, 38, 104, 177, 115, 182, 105, 165, 134, 79, 49, 162 }, "skinner" },
                    { 10, "Lupton", "Luxembourg", new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "I am interesed in blablabla", "IntroductionBlablabla", "davis", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 28, 210, 120, 21, 23, 157, 13, 242, 179, 4, 68, 194, 212, 29, 104, 204, 184, 47, 53, 109, 182, 140, 116, 160, 162, 175, 233, 76, 43, 78, 125, 14, 130, 229, 100, 34, 33, 10, 137, 82, 142, 200, 248, 125, 212, 93, 173, 43, 225, 236, 232, 154, 120, 166, 47, 104, 129, 104, 41, 95, 252, 174, 121, 31 }, new byte[] { 164, 67, 160, 196, 78, 236, 64, 63, 106, 175, 71, 159, 19, 173, 125, 199, 124, 83, 183, 178, 67, 70, 48, 165, 229, 232, 58, 193, 102, 67, 17, 239, 98, 83, 147, 206, 200, 101, 53, 186, 196, 207, 78, 189, 172, 178, 233, 93, 240, 39, 154, 0, 187, 6, 114, 146, 39, 90, 65, 76, 136, 57, 185, 104, 92, 20, 202, 41, 47, 12, 134, 172, 20, 135, 181, 55, 164, 177, 226, 57, 40, 236, 174, 167, 102, 32, 206, 28, 54, 206, 209, 115, 83, 251, 107, 5, 64, 115, 230, 202, 47, 249, 189, 177, 32, 215, 183, 9, 14, 97, 237, 2, 255, 102, 85, 177, 125, 120, 255, 124, 25, 56, 143, 231, 156, 157, 177, 249 }, "davis" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AppUserId", "IsMain", "PublicId", "Url" },
                values: new object[,]
                {
                    { 1, 1, true, null, "https://randomuser.me/api/portraits/women/54.jpg" },
                    { 2, 2, true, null, "https://randomuser.me/api/portraits/women/50.jpg" },
                    { 3, 3, true, null, "https://randomuser.me/api/portraits/women/14.jpg" },
                    { 4, 4, true, null, "https://randomuser.me/api/portraits/women/11.jpg" },
                    { 5, 5, true, null, "https://randomuser.me/api/portraits/men/84.jpg" },
                    { 6, 6, true, null, "https://randomuser.me/api/portraits/men/90.jpg" },
                    { 7, 7, true, null, "https://randomuser.me/api/portraits/men/87.jpg" },
                    { 8, 8, true, null, "https://randomuser.me/api/portraits/men/57.jpg" },
                    { 9, 9, true, null, "https://randomuser.me/api/portraits/men/11.jpg" },
                    { 10, 10, true, null, "https://randomuser.me/api/portraits/men/93.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AppUserId",
                table: "Photos",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}