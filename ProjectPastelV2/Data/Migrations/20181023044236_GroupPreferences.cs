using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectPastelV2.Data.Migrations
{
    public partial class GroupPreferences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Preference",
                columns: table => new
                {
                    PreferenceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true),
                    PreferenceDate = table.Column<string>(nullable: true),
                    PreferenceNo = table.Column<int>(nullable: false),
                    SponsoredProjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preference", x => x.PreferenceId);
                    table.ForeignKey(
                        name: "FK_Preference_SponsoredProject_SponsoredProjectId",
                        column: x => x.SponsoredProjectId,
                        principalTable: "SponsoredProject",
                        principalColumn: "SponsoredProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Preference_SponsoredProjectId",
                table: "Preference",
                column: "SponsoredProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Preference");
        }
    }
}
