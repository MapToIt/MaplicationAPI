using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MaplicationAPI.Migrations
{
    public partial class UpdateIcollectionsToForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Coordinator_CoordinatorId",
                table: "Event");

            migrationBuilder.AlterColumn<int>(
                name: "CoordinatorId",
                table: "Event",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Coordinator_CoordinatorId",
                table: "Event",
                column: "CoordinatorId",
                principalTable: "Coordinator",
                principalColumn: "CoordinatorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Coordinator_CoordinatorId",
                table: "Event");

            migrationBuilder.AlterColumn<int>(
                name: "CoordinatorId",
                table: "Event",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Coordinator_CoordinatorId",
                table: "Event",
                column: "CoordinatorId",
                principalTable: "Coordinator",
                principalColumn: "CoordinatorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
