using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class RenameEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vote");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Answer");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Answer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OptionId",
                table: "Answer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Option",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    PollId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Option", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Option_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_AuthorId",
                table: "Answer",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_OptionId",
                table: "Answer",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_PollId",
                table: "Option",
                column: "PollId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_User_AuthorId",
                table: "Answer",
                column: "AuthorId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Option_OptionId",
                table: "Answer",
                column: "OptionId",
                principalTable: "Option",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_User_AuthorId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Option_OptionId",
                table: "Answer");

            migrationBuilder.DropTable(
                name: "Option");

            migrationBuilder.DropIndex(
                name: "IX_Answer_AuthorId",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_OptionId",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "OptionId",
                table: "Answer");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Answer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerId = table.Column<int>(type: "int", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    PollId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vote_Answer_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vote_User_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vote_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vote_AnswerId",
                table: "Vote",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vote_AuthorId",
                table: "Vote",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vote_PollId",
                table: "Vote",
                column: "PollId");
        }
    }
}
