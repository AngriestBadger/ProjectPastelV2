using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectPastelV2.Data.Migrations
{
    public partial class SponsoredProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Preference_SponsoredProject_SponsoredProjectId",
                table: "Preference");

            migrationBuilder.DropIndex(
                name: "IX_Preference_SponsoredProjectId",
                table: "Preference");

            migrationBuilder.DropColumn(
                name: "PreferenceNo",
                table: "Preference");

            migrationBuilder.DropColumn(
                name: "ProjectTitle",
                table: "Preference");

            migrationBuilder.DropColumn(
                name: "SponsoredProjectId",
                table: "Preference");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "SponsoredProject",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SponsorName",
                table: "SponsoredProject",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SponsoredProject",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contacts",
                table: "SponsoredProject",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreferenceId",
                table: "SponsoredProject",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GroupName",
                table: "Preference",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Preference1",
                table: "Preference",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Preference2",
                table: "Preference",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Preference3",
                table: "Preference",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SponsoredProject_PreferenceId",
                table: "SponsoredProject",
                column: "PreferenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SponsoredProject_Preference_PreferenceId",
                table: "SponsoredProject",
                column: "PreferenceId",
                principalTable: "Preference",
                principalColumn: "PreferenceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SponsoredProject_Preference_PreferenceId",
                table: "SponsoredProject");

            migrationBuilder.DropIndex(
                name: "IX_SponsoredProject_PreferenceId",
                table: "SponsoredProject");

            migrationBuilder.DropColumn(
                name: "PreferenceId",
                table: "SponsoredProject");

            migrationBuilder.DropColumn(
                name: "Preference1",
                table: "Preference");

            migrationBuilder.DropColumn(
                name: "Preference2",
                table: "Preference");

            migrationBuilder.DropColumn(
                name: "Preference3",
                table: "Preference");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "SponsoredProject",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "SponsorName",
                table: "SponsoredProject",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SponsoredProject",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Contacts",
                table: "SponsoredProject",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "GroupName",
                table: "Preference",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "PreferenceNo",
                table: "Preference",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProjectTitle",
                table: "Preference",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SponsoredProjectId",
                table: "Preference",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Preference_SponsoredProjectId",
                table: "Preference",
                column: "SponsoredProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Preference_SponsoredProject_SponsoredProjectId",
                table: "Preference",
                column: "SponsoredProjectId",
                principalTable: "SponsoredProject",
                principalColumn: "SponsoredProjectId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
