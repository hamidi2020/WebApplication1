using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class FirstMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kelases_Courses_CourseID",
                table: "Kelases");

            migrationBuilder.DropForeignKey(
                name: "FK_Kelases_Teachers_TeacherID",
                table: "Kelases");

            migrationBuilder.DropForeignKey(
                name: "FK_KelasStudent_Kelases_KelasesKelasID",
                table: "KelasStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_KelasStudent_Stusents_StudentsStudentID",
                table: "KelasStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stusents",
                table: "Stusents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kelases",
                table: "Kelases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "Teacher");

            migrationBuilder.RenameTable(
                name: "Stusents",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Kelases",
                newName: "Kelas");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_Kelases_TeacherID",
                table: "Kelas",
                newName: "IX_Kelas_TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_Kelases_CourseID",
                table: "Kelas",
                newName: "IX_Kelas_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher",
                column: "TeacherID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "StudentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kelas",
                table: "Kelas",
                column: "KelasID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kelas_Course_CourseID",
                table: "Kelas",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kelas_Teacher_TeacherID",
                table: "Kelas",
                column: "TeacherID",
                principalTable: "Teacher",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KelasStudent_Kelas_KelasesKelasID",
                table: "KelasStudent",
                column: "KelasesKelasID",
                principalTable: "Kelas",
                principalColumn: "KelasID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KelasStudent_Student_StudentsStudentID",
                table: "KelasStudent",
                column: "StudentsStudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kelas_Course_CourseID",
                table: "Kelas");

            migrationBuilder.DropForeignKey(
                name: "FK_Kelas_Teacher_TeacherID",
                table: "Kelas");

            migrationBuilder.DropForeignKey(
                name: "FK_KelasStudent_Kelas_KelasesKelasID",
                table: "KelasStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_KelasStudent_Student_StudentsStudentID",
                table: "KelasStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kelas",
                table: "Kelas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "Teachers");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Stusents");

            migrationBuilder.RenameTable(
                name: "Kelas",
                newName: "Kelases");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Kelas_TeacherID",
                table: "Kelases",
                newName: "IX_Kelases_TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_Kelas_CourseID",
                table: "Kelases",
                newName: "IX_Kelases_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "TeacherID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stusents",
                table: "Stusents",
                column: "StudentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kelases",
                table: "Kelases",
                column: "KelasID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kelases_Courses_CourseID",
                table: "Kelases",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kelases_Teachers_TeacherID",
                table: "Kelases",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KelasStudent_Kelases_KelasesKelasID",
                table: "KelasStudent",
                column: "KelasesKelasID",
                principalTable: "Kelases",
                principalColumn: "KelasID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KelasStudent_Stusents_StudentsStudentID",
                table: "KelasStudent",
                column: "StudentsStudentID",
                principalTable: "Stusents",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
