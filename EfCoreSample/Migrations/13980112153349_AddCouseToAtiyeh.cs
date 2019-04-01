using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreSample.Migrations
{
    public partial class AddCouseToAtiyeh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_people_PersonId",
                table: "Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "courses");

            migrationBuilder.RenameIndex(
                name: "IX_Course_PersonId",
                table: "courses",
                newName: "IX_courses_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "courses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_courses",
                table: "courses",
                column: "id");

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "id", "Name", "PersonId" },
                values: new object[] { 1, "فیزیک هسته ای", 1 });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "id", "Name", "PersonId" },
                values: new object[] { 2, "اختر فیزیک", 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_courses_people_PersonId",
                table: "courses",
                column: "PersonId",
                principalTable: "people",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_people_PersonId",
                table: "courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courses",
                table: "courses");

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_courses_PersonId",
                table: "Course",
                newName: "IX_Course_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Course",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_people_PersonId",
                table: "Course",
                column: "PersonId",
                principalTable: "people",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}