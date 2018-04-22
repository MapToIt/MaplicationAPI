using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MaplicationAPI.Migrations
{
    public partial class addRecuriterAndJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chips",
                table: "JobPostings");

            migrationBuilder.AddColumn<string>(
                name: "AlmaMater",
                table: "Recruiter",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "JobPostings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "BaseSalary",
                table: "JobPostings",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePosted",
                table: "JobPostings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EmploymentTypeId",
                table: "JobPostings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalaryTypeId",
                table: "JobPostings",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidThrough",
                table: "JobPostings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "EmploymentTypes",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmploymentType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentTypes", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "SalaryTypes",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SalaryType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryTypes", x => x.TypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobPostings_EmploymentTypeId",
                table: "JobPostings",
                column: "EmploymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPostings_SalaryTypeId",
                table: "JobPostings",
                column: "SalaryTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostings_EmploymentTypes_EmploymentTypeId",
                table: "JobPostings",
                column: "EmploymentTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostings_EmploymentTypes_SalaryTypeId",
                table: "JobPostings",
                column: "SalaryTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPostings_EmploymentTypes_EmploymentTypeId",
                table: "JobPostings");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostings_EmploymentTypes_SalaryTypeId",
                table: "JobPostings");

            migrationBuilder.DropTable(
                name: "EmploymentTypes");

            migrationBuilder.DropTable(
                name: "SalaryTypes");

            migrationBuilder.DropIndex(
                name: "IX_JobPostings_EmploymentTypeId",
                table: "JobPostings");

            migrationBuilder.DropIndex(
                name: "IX_JobPostings_SalaryTypeId",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "AlmaMater",
                table: "Recruiter");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "BaseSalary",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "DatePosted",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "EmploymentTypeId",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "SalaryTypeId",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "ValidThrough",
                table: "JobPostings");

            migrationBuilder.AddColumn<string>(
                name: "Chips",
                table: "JobPostings",
                nullable: true);
        }
    }
}
