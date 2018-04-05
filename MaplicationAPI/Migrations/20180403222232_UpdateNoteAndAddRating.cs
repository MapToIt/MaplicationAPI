using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MaplicationAPI.Migrations
{
    public partial class UpdateNoteAndAddRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_User_CompanyId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Major",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Notes");

            migrationBuilder.AddColumn<int>(
                name: "AttendeeId",
                table: "Notes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Notes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RatingId",
                table: "Notes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RatingType",
                columns: table => new
                {
                    RatingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingType", x => x.RatingId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_AttendeeId",
                table: "Notes",
                column: "AttendeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_EventId",
                table: "Notes",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_RatingId",
                table: "Notes",
                column: "RatingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Attendee_AttendeeId",
                table: "Notes",
                column: "AttendeeId",
                principalTable: "Attendee",
                principalColumn: "AttendeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Company_CompanyId",
                table: "Notes",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Event_EventId",
                table: "Notes",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_RatingType_RatingId",
                table: "Notes",
                column: "RatingId",
                principalTable: "RatingType",
                principalColumn: "RatingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Attendee_AttendeeId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Company_CompanyId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Event_EventId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_RatingType_RatingId",
                table: "Notes");

            migrationBuilder.DropTable(
                name: "RatingType");

            migrationBuilder.DropIndex(
                name: "IX_Notes_AttendeeId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_EventId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_RatingId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "AttendeeId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "RatingId",
                table: "Notes");

            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_User_CompanyId",
                table: "Notes",
                column: "CompanyId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
