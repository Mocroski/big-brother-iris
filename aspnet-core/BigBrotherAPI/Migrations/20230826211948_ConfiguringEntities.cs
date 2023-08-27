using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BigBrotherAPI.Migrations
{
    /// <inheritdoc />
    public partial class ConfiguringEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Poll",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClosureTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poll", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PollResult",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PollId = table.Column<string>(type: "TEXT", nullable: false),
                    PollName = table.Column<string>(type: "TEXT", nullable: false),
                    PollStarteDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PollEndDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PollResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motherfucker",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    IsEliminated = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasVoted = table.Column<bool>(type: "INTEGER", nullable: false),
                    PollId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherfucker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motherfucker_Poll_PollId",
                        column: x => x.PollId,
                        principalTable: "Poll",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PollResultMotherfucker",
                columns: table => new
                {
                    MotherfuckerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MotherfuckerId1 = table.Column<Guid>(type: "TEXT", nullable: false),
                    PercentageOfVotes = table.Column<decimal>(type: "TEXT", nullable: false),
                    NumberOfVotes = table.Column<int>(type: "INTEGER", nullable: false),
                    PollResultId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PollResultMotherfucker", x => x.MotherfuckerId);
                    table.ForeignKey(
                        name: "FK_PollResultMotherfucker_Motherfucker_MotherfuckerId1",
                        column: x => x.MotherfuckerId1,
                        principalTable: "Motherfucker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PollResultMotherfucker_PollResult_PollResultId",
                        column: x => x.PollResultId,
                        principalTable: "PollResult",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vote",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PollId = table.Column<string>(type: "TEXT", nullable: false),
                    MotherfuckerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Reason = table.Column<string>(type: "TEXT", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ExtraProperties = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vote_Motherfucker_MotherfuckerId",
                        column: x => x.MotherfuckerId,
                        principalTable: "Motherfucker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motherfucker_PollId",
                table: "Motherfucker",
                column: "PollId");

            migrationBuilder.CreateIndex(
                name: "IX_PollResultMotherfucker_MotherfuckerId1",
                table: "PollResultMotherfucker",
                column: "MotherfuckerId1");

            migrationBuilder.CreateIndex(
                name: "IX_PollResultMotherfucker_PollResultId",
                table: "PollResultMotherfucker",
                column: "PollResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Vote_MotherfuckerId",
                table: "Vote",
                column: "MotherfuckerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PollResultMotherfucker");

            migrationBuilder.DropTable(
                name: "Vote");

            migrationBuilder.DropTable(
                name: "PollResult");

            migrationBuilder.DropTable(
                name: "Motherfucker");

            migrationBuilder.DropTable(
                name: "Poll");
        }
    }
}
