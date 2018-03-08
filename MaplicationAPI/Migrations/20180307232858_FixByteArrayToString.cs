using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MaplicationAPI.Migrations
{
    public partial class FixByteArrayToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendee_User_UserId",
                table: "Attendee");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_State_StateId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_User_UserId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinator_User_UserId",
                table: "Coordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Coordinator_CoordinatorId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_State_StateId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostings_Company_CompanyId",
                table: "JobPostings");

            migrationBuilder.DropForeignKey(
                name: "FK_Map_Event_EventId",
                table: "Map");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_User_CompanyId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recruiter_Company_CompanyId",
                table: "Recruiter");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Company_CompanyId",
                table: "Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Map_MapId",
                table: "Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserTypes_UserTypeId",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Tables",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Tables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Tables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "XCoordinate",
                table: "Tables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YCoordinate",
                table: "Tables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Recruiter",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Map",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Company",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Resume",
                table: "Attendee",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Attendee",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Attendee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Attendee",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendee_User_UserId",
                table: "Attendee",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_State_StateId",
                table: "Company",
                column: "StateId",
                principalTable: "State",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_User_UserId",
                table: "Company",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinator_User_UserId",
                table: "Coordinator",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Coordinator_CoordinatorId",
                table: "Event",
                column: "CoordinatorId",
                principalTable: "Coordinator",
                principalColumn: "CoordinatorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_State_StateId",
                table: "Event",
                column: "StateId",
                principalTable: "State",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostings_Company_CompanyId",
                table: "JobPostings",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Map_Event_EventId",
                table: "Map",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_User_CompanyId",
                table: "Notes",
                column: "CompanyId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recruiter_Company_CompanyId",
                table: "Recruiter",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Company_CompanyId",
                table: "Tables",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Map_MapId",
                table: "Tables",
                column: "MapId",
                principalTable: "Map",
                principalColumn: "MapId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserTypes_UserTypeId",
                table: "User",
                column: "UserTypeId",
                principalTable: "UserTypes",
                principalColumn: "UserTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendee_User_UserId",
                table: "Attendee");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_State_StateId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_User_UserId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinator_User_UserId",
                table: "Coordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Coordinator_CoordinatorId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_State_StateId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPostings_Company_CompanyId",
                table: "JobPostings");

            migrationBuilder.DropForeignKey(
                name: "FK_Map_Event_EventId",
                table: "Map");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_User_CompanyId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recruiter_Company_CompanyId",
                table: "Recruiter");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Company_CompanyId",
                table: "Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Map_MapId",
                table: "Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserTypes_UserTypeId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "XCoordinate",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "YCoordinate",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Attendee");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Attendee");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Tables",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "Recruiter",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Map",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Logo",
                table: "Company",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Resume",
                table: "Attendee",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Attendee",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendee_User_UserId",
                table: "Attendee",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_State_StateId",
                table: "Company",
                column: "StateId",
                principalTable: "State",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_User_UserId",
                table: "Company",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinator_User_UserId",
                table: "Coordinator",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Coordinator_CoordinatorId",
                table: "Event",
                column: "CoordinatorId",
                principalTable: "Coordinator",
                principalColumn: "CoordinatorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_State_StateId",
                table: "Event",
                column: "StateId",
                principalTable: "State",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostings_Company_CompanyId",
                table: "JobPostings",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Map_Event_EventId",
                table: "Map",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_User_CompanyId",
                table: "Notes",
                column: "CompanyId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recruiter_Company_CompanyId",
                table: "Recruiter",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Company_CompanyId",
                table: "Tables",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Map_MapId",
                table: "Tables",
                column: "MapId",
                principalTable: "Map",
                principalColumn: "MapId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserTypes_UserTypeId",
                table: "User",
                column: "UserTypeId",
                principalTable: "UserTypes",
                principalColumn: "UserTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
