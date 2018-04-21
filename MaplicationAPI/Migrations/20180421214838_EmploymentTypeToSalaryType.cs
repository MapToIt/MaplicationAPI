using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MaplicationAPI.Migrations
{
    public partial class EmploymentTypeToSalaryType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPostings_EmploymentTypes_SalaryTypeId",
                table: "JobPostings");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostings_SalaryTypes_SalaryTypeId",
                table: "JobPostings",
                column: "SalaryTypeId",
                principalTable: "SalaryTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPostings_SalaryTypes_SalaryTypeId",
                table: "JobPostings");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostings_EmploymentTypes_SalaryTypeId",
                table: "JobPostings",
                column: "SalaryTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
