using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeltExam.Migrations
{
    public partial class SetupHangoutParticipantTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hangouts",
                columns: table => new
                {
                    HangoutId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: true),
                    Time = table.Column<DateTime>(nullable: true),
                    Duration = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hangouts", x => x.HangoutId);
                    table.ForeignKey(
                        name: "FK_hangouts_users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "hangoutParticipants",
                columns: table => new
                {
                    HangoutParticipantId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HangoutId = table.Column<int>(nullable: false),
                    ParticipantId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hangoutParticipants", x => x.HangoutParticipantId);
                    table.ForeignKey(
                        name: "FK_hangoutParticipants_hangouts_HangoutId",
                        column: x => x.HangoutId,
                        principalTable: "hangouts",
                        principalColumn: "HangoutId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hangoutParticipants_users_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hangoutParticipants_HangoutId",
                table: "hangoutParticipants",
                column: "HangoutId");

            migrationBuilder.CreateIndex(
                name: "IX_hangoutParticipants_ParticipantId",
                table: "hangoutParticipants",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_hangouts_CreatorId",
                table: "hangouts",
                column: "CreatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hangoutParticipants");

            migrationBuilder.DropTable(
                name: "hangouts");
        }
    }
}
