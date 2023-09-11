using System;
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
                    { 1, "Greenbush", "Martinique", new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", "I am interesed in blablabla", "IntroductionBlablabla", "liza", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 183, 234, 4, 3, 199, 255, 85, 154, 71, 170, 8, 149, 98, 159, 249, 88, 46, 111, 254, 23, 92, 143, 47, 250, 50, 134, 84, 33, 14, 112, 82, 86, 178, 37, 236, 217, 226, 143, 210, 140, 106, 71, 18, 184, 127, 105, 200, 240, 97, 208, 193, 22, 209, 90, 78, 110, 21, 103, 210, 147, 112, 65, 59, 18 }, new byte[] { 184, 47, 188, 128, 12, 219, 58, 82, 6, 11, 93, 140, 150, 166, 43, 225, 115, 138, 38, 70, 199, 56, 42, 15, 27, 119, 237, 128, 236, 143, 3, 195, 175, 73, 99, 66, 191, 196, 226, 107, 199, 234, 213, 172, 52, 153, 187, 121, 165, 70, 17, 27, 182, 220, 6, 233, 52, 121, 5, 110, 232, 98, 15, 142, 19, 66, 135, 123, 47, 255, 154, 187, 23, 149, 223, 179, 74, 71, 240, 54, 227, 222, 249, 89, 168, 238, 203, 182, 88, 210, 224, 44, 159, 184, 18, 172, 238, 208, 188, 216, 108, 53, 12, 198, 36, 66, 109, 230, 245, 134, 207, 155, 183, 209, 129, 152, 52, 101, 195, 118, 63, 102, 192, 190, 194, 161, 59, 77 }, "liza" },
                    { 2, "Celeryville", "Grenada", new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", "I am interesed in blablabla", "IntroductionBlablabla", "karen", new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 171, 19, 255, 19, 112, 67, 45, 155, 95, 149, 147, 189, 223, 205, 54, 47, 59, 165, 179, 27, 79, 161, 208, 3, 77, 172, 225, 150, 224, 207, 205, 218, 154, 187, 223, 18, 97, 61, 182, 65, 17, 67, 46, 149, 177, 71, 18, 116, 21, 5, 239, 77, 22, 158, 160, 172, 72, 62, 161, 174, 206, 150, 4, 111 }, new byte[] { 115, 236, 0, 160, 60, 16, 177, 164, 71, 143, 35, 116, 42, 177, 202, 203, 31, 225, 31, 50, 126, 204, 61, 43, 32, 86, 57, 255, 71, 229, 103, 39, 65, 122, 117, 161, 62, 57, 201, 238, 133, 128, 235, 139, 134, 168, 18, 133, 1, 170, 20, 165, 117, 96, 243, 40, 187, 74, 67, 5, 120, 222, 2, 78, 181, 169, 122, 104, 241, 170, 244, 187, 76, 21, 14, 99, 89, 232, 156, 199, 48, 106, 221, 190, 32, 73, 147, 230, 104, 10, 9, 58, 35, 32, 162, 81, 65, 14, 13, 244, 128, 200, 126, 210, 135, 140, 187, 224, 26, 48, 185, 39, 132, 186, 100, 146, 47, 159, 192, 114, 65, 232, 159, 51, 71, 13, 139, 84 }, "karen" },
                    { 3, "Rosewood", "Svalbard and Jan Mayen Islands", new DateTime(2019, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1959, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", "I am interesed in blablabla", "IntroductionBlablabla", "margo", new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 42, 145, 161, 34, 178, 153, 17, 245, 230, 163, 116, 34, 18, 4, 62, 78, 78, 202, 13, 46, 164, 111, 83, 176, 202, 195, 30, 96, 237, 42, 137, 105, 201, 225, 158, 102, 99, 39, 228, 53, 109, 199, 41, 215, 47, 250, 45, 193, 81, 106, 50, 84, 78, 111, 46, 166, 114, 0, 152, 212, 38, 36, 58, 69 }, new byte[] { 32, 62, 29, 15, 156, 73, 1, 242, 50, 70, 244, 55, 138, 54, 37, 255, 213, 13, 222, 91, 88, 202, 74, 123, 120, 253, 114, 226, 41, 243, 11, 183, 35, 123, 91, 106, 40, 5, 231, 32, 150, 125, 68, 250, 4, 177, 248, 161, 46, 51, 33, 248, 103, 124, 247, 198, 49, 202, 192, 16, 104, 0, 159, 101, 64, 126, 65, 35, 222, 194, 32, 233, 164, 68, 150, 246, 131, 253, 243, 226, 149, 55, 86, 85, 67, 153, 155, 254, 193, 172, 221, 43, 248, 248, 182, 170, 39, 166, 35, 124, 69, 102, 139, 151, 220, 96, 175, 140, 74, 71, 110, 42, 45, 126, 201, 172, 75, 103, 31, 30, 211, 95, 79, 19, 73, 177, 51, 49 }, "margo" },
                    { 4, "Orviston", "Zimbabwe", new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", "I am interesed in blablabla", "IntroductionBlablabla", "lois", new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 248, 35, 114, 177, 126, 74, 197, 106, 52, 214, 232, 97, 198, 40, 223, 227, 27, 47, 1, 12, 206, 177, 55, 147, 202, 225, 237, 211, 133, 254, 48, 66, 225, 146, 121, 55, 199, 93, 237, 78, 51, 117, 149, 176, 58, 243, 221, 47, 161, 218, 73, 124, 1, 233, 202, 204, 70, 187, 229, 93, 209, 112, 68, 54 }, new byte[] { 115, 70, 236, 122, 27, 39, 206, 112, 77, 140, 9, 23, 17, 245, 34, 142, 34, 232, 87, 36, 106, 168, 30, 122, 131, 188, 225, 171, 66, 63, 226, 124, 162, 144, 121, 0, 151, 38, 117, 24, 124, 121, 102, 155, 247, 179, 40, 5, 86, 226, 134, 126, 251, 17, 86, 51, 157, 83, 2, 204, 103, 49, 61, 90, 3, 0, 8, 141, 70, 149, 196, 97, 199, 137, 56, 103, 218, 206, 24, 59, 49, 237, 212, 25, 39, 29, 135, 98, 237, 99, 51, 189, 207, 144, 112, 132, 61, 33, 112, 201, 200, 106, 235, 244, 244, 209, 202, 170, 22, 130, 28, 244, 38, 72, 98, 198, 210, 238, 242, 117, 66, 153, 25, 30, 166, 16, 121, 104 }, "lois" },
                    { 5, "Germanton", "Antigua and Barbuda", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1956, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", "I am interesed in blablabla", "IntroductionBlablabla", "ruthie", new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 11, 12, 2, 76, 106, 173, 165, 71, 133, 123, 19, 89, 192, 131, 196, 234, 216, 182, 139, 100, 237, 79, 87, 167, 171, 22, 2, 39, 165, 200, 197, 182, 109, 128, 235, 16, 124, 210, 197, 227, 115, 243, 71, 71, 210, 193, 2, 167, 39, 66, 193, 241, 155, 215, 232, 142, 51, 77, 182, 128, 125, 255, 13, 117 }, new byte[] { 85, 92, 215, 172, 251, 73, 133, 29, 187, 72, 47, 181, 59, 241, 115, 59, 175, 40, 119, 160, 208, 27, 155, 4, 7, 15, 87, 57, 113, 80, 110, 109, 146, 186, 168, 192, 114, 44, 113, 120, 179, 246, 156, 207, 192, 189, 70, 99, 75, 151, 119, 250, 127, 69, 118, 16, 69, 66, 103, 217, 168, 110, 79, 208, 231, 124, 175, 27, 239, 85, 217, 194, 212, 201, 22, 214, 148, 80, 37, 207, 184, 39, 250, 113, 235, 186, 190, 179, 180, 2, 69, 233, 63, 204, 116, 62, 24, 0, 35, 252, 70, 117, 112, 21, 117, 46, 229, 61, 65, 252, 116, 15, 6, 180, 156, 205, 18, 217, 194, 210, 85, 96, 174, 17, 124, 106, 134, 14 }, "ruthie" },
                    { 6, "Cliff", "British Indian Ocean Territory", new DateTime(2019, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "I am interesed in blablabla", "IntroductionBlablabla", "todd", new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 245, 41, 122, 206, 172, 221, 248, 2, 190, 139, 119, 81, 142, 209, 65, 181, 152, 206, 58, 46, 103, 90, 178, 204, 54, 80, 232, 162, 66, 81, 255, 168, 198, 6, 117, 57, 114, 179, 64, 139, 17, 197, 161, 48, 99, 238, 31, 179, 105, 40, 98, 92, 250, 201, 240, 241, 24, 66, 132, 225, 115, 149, 107, 124 }, new byte[] { 216, 210, 155, 0, 252, 42, 244, 100, 35, 83, 4, 221, 74, 42, 200, 149, 207, 117, 161, 96, 208, 168, 142, 5, 73, 120, 158, 239, 236, 98, 26, 153, 6, 87, 35, 67, 24, 9, 64, 42, 66, 12, 26, 91, 234, 133, 170, 72, 24, 62, 231, 202, 79, 230, 245, 122, 233, 17, 115, 182, 121, 132, 51, 51, 89, 12, 162, 46, 210, 254, 181, 67, 35, 166, 88, 98, 210, 222, 215, 162, 246, 186, 210, 68, 97, 46, 104, 219, 214, 213, 254, 48, 246, 189, 202, 50, 127, 205, 112, 211, 195, 171, 29, 23, 148, 50, 76, 197, 224, 34, 7, 106, 46, 61, 54, 101, 230, 226, 76, 198, 111, 238, 14, 68, 78, 39, 216, 164 }, "todd" },
                    { 7, "Welda", "Christmas Island", new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1967, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "I am interesed in blablabla", "IntroductionBlablabla", "porter", new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 148, 61, 33, 120, 148, 0, 25, 33, 228, 90, 176, 97, 24, 159, 176, 254, 219, 246, 94, 35, 239, 115, 12, 13, 22, 104, 3, 221, 88, 76, 155, 248, 239, 103, 232, 202, 160, 202, 238, 77, 226, 177, 103, 145, 129, 124, 135, 95, 15, 54, 34, 120, 217, 155, 53, 7, 0, 134, 46, 223, 80, 62, 111, 228 }, new byte[] { 42, 156, 121, 35, 149, 132, 84, 126, 97, 157, 181, 114, 95, 68, 233, 237, 9, 82, 240, 183, 75, 26, 86, 187, 156, 232, 3, 13, 193, 70, 152, 215, 38, 121, 92, 113, 185, 224, 147, 118, 163, 115, 152, 21, 4, 110, 174, 183, 103, 104, 123, 137, 228, 84, 11, 170, 185, 176, 47, 214, 219, 213, 99, 157, 51, 89, 20, 229, 137, 156, 134, 106, 122, 55, 65, 255, 196, 37, 244, 36, 104, 198, 55, 186, 245, 74, 1, 98, 220, 239, 19, 187, 117, 174, 88, 106, 86, 122, 187, 178, 144, 135, 248, 122, 99, 111, 49, 75, 32, 162, 97, 249, 163, 202, 57, 51, 138, 77, 116, 206, 217, 8, 116, 19, 243, 148, 183, 217 }, "porter" },
                    { 8, "Calrence", "Burkina Faso", new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "I am interesed in blablabla", "IntroductionBlablabla", "mayo", new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 53, 165, 0, 58, 6, 37, 78, 153, 95, 139, 57, 14, 177, 173, 246, 117, 70, 62, 92, 127, 115, 182, 206, 93, 235, 50, 217, 107, 161, 152, 242, 108, 116, 58, 196, 25, 41, 49, 198, 240, 248, 174, 183, 172, 47, 28, 97, 1, 112, 127, 94, 221, 10, 25, 28, 8, 36, 47, 1, 112, 142, 86, 187, 225 }, new byte[] { 124, 138, 145, 184, 186, 76, 243, 98, 135, 102, 2, 7, 135, 189, 67, 127, 108, 243, 205, 106, 24, 98, 187, 172, 121, 195, 90, 239, 208, 142, 23, 235, 163, 185, 194, 8, 234, 28, 118, 28, 117, 67, 54, 229, 39, 165, 242, 67, 161, 197, 138, 253, 236, 135, 83, 201, 15, 52, 110, 202, 169, 18, 148, 247, 185, 103, 134, 175, 10, 91, 225, 68, 255, 39, 230, 171, 31, 47, 194, 10, 202, 6, 116, 6, 168, 52, 77, 4, 89, 130, 242, 184, 0, 161, 137, 10, 0, 23, 206, 83, 193, 91, 168, 206, 109, 62, 226, 35, 133, 175, 193, 126, 115, 135, 134, 153, 238, 21, 126, 244, 154, 160, 140, 204, 132, 252, 14, 198 }, "mayo" },
                    { 9, "Herald", "Poland", new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1952, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "I am interesed in blablabla", "IntroductionBlablabla", "skinner", new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 170, 40, 97, 173, 235, 27, 126, 241, 95, 133, 180, 143, 70, 76, 189, 90, 40, 121, 171, 22, 61, 102, 212, 247, 49, 109, 210, 158, 59, 252, 215, 125, 102, 222, 51, 143, 64, 179, 245, 73, 194, 108, 126, 41, 111, 140, 13, 175, 162, 141, 175, 248, 111, 243, 62, 75, 10, 26, 22, 145, 125, 218, 202, 235 }, new byte[] { 164, 169, 81, 28, 118, 254, 195, 144, 43, 221, 19, 159, 90, 26, 153, 137, 147, 5, 22, 171, 185, 209, 119, 74, 17, 91, 230, 74, 97, 197, 106, 143, 35, 49, 133, 136, 182, 190, 101, 222, 205, 183, 88, 20, 242, 153, 179, 182, 41, 82, 90, 63, 180, 22, 140, 206, 0, 221, 153, 115, 225, 162, 141, 40, 101, 214, 237, 56, 252, 182, 200, 95, 76, 82, 55, 87, 23, 85, 33, 36, 50, 44, 58, 240, 234, 255, 71, 159, 71, 83, 79, 72, 213, 206, 245, 64, 255, 148, 103, 179, 204, 231, 75, 164, 2, 76, 244, 45, 175, 164, 74, 210, 191, 33, 79, 1, 42, 99, 187, 87, 123, 133, 133, 127, 82, 252, 204, 218 }, "skinner" },
                    { 10, "Lupton", "Luxembourg", new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "I am interesed in blablabla", "IntroductionBlablabla", "davis", new DateTime(2020, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "LookingForBlablabla", new byte[] { 7, 108, 196, 58, 228, 154, 126, 28, 113, 128, 21, 236, 238, 200, 86, 174, 20, 208, 30, 231, 207, 184, 65, 160, 206, 240, 27, 20, 139, 42, 2, 46, 0, 201, 56, 133, 108, 228, 182, 246, 47, 88, 184, 220, 113, 228, 95, 161, 183, 50, 33, 33, 249, 69, 11, 6, 52, 89, 108, 177, 177, 34, 216, 216 }, new byte[] { 12, 38, 149, 43, 218, 5, 177, 246, 102, 181, 82, 98, 122, 19, 234, 235, 191, 101, 245, 190, 169, 182, 67, 48, 183, 160, 170, 255, 217, 249, 69, 227, 85, 116, 107, 85, 64, 155, 168, 158, 132, 164, 7, 217, 138, 239, 114, 73, 28, 165, 116, 209, 120, 138, 167, 37, 218, 89, 69, 151, 70, 171, 27, 43, 211, 70, 206, 65, 174, 125, 145, 109, 24, 117, 242, 3, 44, 234, 45, 181, 161, 136, 88, 212, 193, 143, 172, 249, 59, 131, 78, 91, 189, 240, 108, 124, 159, 98, 22, 199, 143, 110, 75, 67, 215, 11, 97, 106, 172, 15, 82, 154, 50, 225, 60, 237, 49, 214, 155, 126, 96, 142, 106, 196, 249, 106, 94, 12 }, "davis" }
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
                    { 5, 5, true, null, "https://randomuser.me/api/portraits/women/84.jpg" },
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
