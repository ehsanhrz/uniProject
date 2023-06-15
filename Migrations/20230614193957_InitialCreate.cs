using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace uniProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    FatherName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NationalId = table.Column<int>(type: "INTEGER", nullable: false),
                    PassPortCode = table.Column<int>(type: "INTEGER", nullable: false),
                    Sex = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    BirthProvince = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BirthCity = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MilitaryServiceMonth = table.Column<int>(type: "INTEGER", nullable: false),
                    MilitaryServiceEndTime = table.Column<DateOnly>(type: "TEXT", maxLength: 50, nullable: false),
                    Religion = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LeftHandPerson = table.Column<bool>(type: "INTEGER", nullable: false),
                    MarriageStatus = table.Column<bool>(type: "INTEGER", nullable: false),
                    ContractWork = table.Column<bool>(type: "INTEGER", nullable: false),
                    ContractWorkName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MonthOfWork = table.Column<int>(type: "INTEGER", nullable: false),
                    YearOfWork = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicineWork = table.Column<bool>(type: "INTEGER", nullable: false),
                    MedicineWorkName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MonthOfMedicine = table.Column<int>(type: "INTEGER", nullable: false),
                    YearOfMedicine = table.Column<int>(type: "INTEGER", nullable: false),
                    WarTime = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    CaptiveTime = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    InjuredTime = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    FamilyWarHeroMember = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    AgeExceptionCondition = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    EducationLevel = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    EducationTitle = table.Column<string>(type: "TEXT", nullable: false),
                    EducationSchool = table.Column<string>(type: "TEXT", nullable: false),
                    EducationEndTime = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    HomePhoneNumber = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 12, nullable: false),
                    CodePost = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    WantedJobTitle = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LocalProvince = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LocalCity = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SameLocalPlace = table.Column<bool>(type: "INTEGER", nullable: false),
                    ConfirmLocalCity = table.Column<bool>(type: "INTEGER", nullable: false),
                    TrackingId = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    NationalId = table.Column<int>(type: "INTEGER", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Forms_Email",
                table: "Forms",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Forms_NationalId",
                table: "Forms",
                column: "NationalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Forms_PassPortCode",
                table: "Forms",
                column: "PassPortCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Forms_PhoneNumber",
                table: "Forms",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_NationalId",
                table: "Users",
                column: "NationalId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
