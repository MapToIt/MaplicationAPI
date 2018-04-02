using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MaplicationAPI.Migrations
{
    public partial class EventIdOnEventAttendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventAttendance_Event_EventId",
                table: "EventAttendance");

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "EventAttendance",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EventAttendance_Event_EventId",
                table: "EventAttendance",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventAttendance_Event_EventId",
                table: "EventAttendance");

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "EventAttendance",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_EventAttendance_Event_EventId",
                table: "EventAttendance",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
