using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MaplicationAPI.Migrations
{
    public partial class TagsIcollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chips",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "Chips",
                table: "Attendee");

            migrationBuilder.AddColumn<int>(
                name: "AttendeeId",
                table: "Tags",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Tags",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_AttendeeId",
                table: "Tags",
                column: "AttendeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_CompanyId",
                table: "Tags",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Attendee_AttendeeId",
                table: "Tags",
                column: "AttendeeId",
                principalTable: "Attendee",
                principalColumn: "AttendeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Company_CompanyId",
                table: "Tags",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Attendee_AttendeeId",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Company_CompanyId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_AttendeeId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_CompanyId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "AttendeeId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Tags");

            migrationBuilder.AddColumn<string>(
                name: "Chips",
                table: "Company",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Chips",
                table: "Attendee",
                nullable: true);
        }
    }
}
