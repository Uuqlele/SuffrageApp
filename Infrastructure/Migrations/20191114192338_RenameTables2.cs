using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class RenameTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_User_AuthorId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Options_OptionId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Polls_PollId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Polls_User_UserId",
                table: "Polls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answer",
                table: "Answer");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Answer",
                newName: "Answers");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_PollId",
                table: "Answers",
                newName: "IX_Answers_PollId");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_OptionId",
                table: "Answers",
                newName: "IX_Answers_OptionId");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_AuthorId",
                table: "Answers",
                newName: "IX_Answers_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Users_AuthorId",
                table: "Answers",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Options_OptionId",
                table: "Answers",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Polls_PollId",
                table: "Answers",
                column: "PollId",
                principalTable: "Polls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polls_Users_UserId",
                table: "Polls",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Users_AuthorId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Options_OptionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Polls_PollId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Polls_Users_UserId",
                table: "Polls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "Answer");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_PollId",
                table: "Answer",
                newName: "IX_Answer_PollId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_OptionId",
                table: "Answer",
                newName: "IX_Answer_OptionId");

            migrationBuilder.RenameIndex(
                name: "IX_Answers_AuthorId",
                table: "Answer",
                newName: "IX_Answer_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answer",
                table: "Answer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_User_AuthorId",
                table: "Answer",
                column: "AuthorId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Options_OptionId",
                table: "Answer",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Polls_PollId",
                table: "Answer",
                column: "PollId",
                principalTable: "Polls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polls_User_UserId",
                table: "Polls",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
