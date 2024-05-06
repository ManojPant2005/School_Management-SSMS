using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMSS.Api.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AltPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfJoining = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermnentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermnentCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermnentDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermnentPinCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermnentState = table.Column<int>(type: "int", nullable: false),
                    PresentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresentCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresentDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresentPinCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresentState = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffType = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "StudentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdmissionNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    RollNumber = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BloodGroup = table.Column<int>(type: "int", nullable: true),
                    Religion = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: true),
                    Caste = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdharNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfAdmission = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PermnentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermnentCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermnentDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermnentPinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermnentState = table.Column<int>(type: "int", nullable: true),
                    PresentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresentCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresentDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresentPinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresentState = table.Column<int>(type: "int", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionDetails",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaxStudents = table.Column<int>(type: "int", nullable: false),
                    SectionTeacherId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionDetails", x => x.SectionId);
                    table.ForeignKey(
                        name: "FK_SectionDetails_SectionDetails",
                        column: x => x.ClassId,
                        principalTable: "ClassDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubjectDetails",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    SubjectTeacher = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectDetails", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_SubjectDetails_SubjectDetails",
                        column: x => x.ClassId,
                        principalTable: "ClassDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SectionDetails_ClassId",
                table: "SectionDetails",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectDetails_ClassId",
                table: "SubjectDetails",
                column: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SectionDetails");

            migrationBuilder.DropTable(
                name: "StaffDetails");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "StudentDetails");

            migrationBuilder.DropTable(
                name: "SubjectDetails");

            migrationBuilder.DropTable(
                name: "ClassDetails");
        }
    }
}
