using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class FixModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServerParticipants_Users_RoleId",
                table: "ServerParticipants");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Roles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Edited",
                table: "PrivateMessages",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "PrivateMessages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "PrivateMessages",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Edited",
                table: "ChannelMessages",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "ChannelMessages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "ChannelMessages",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateMessages_SenderId",
                table: "PrivateMessages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_ChannelMessages_SenderId",
                table: "ChannelMessages",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChannelMessages_Users_SenderId",
                table: "ChannelMessages",
                column: "SenderId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivateMessages_Users_SenderId",
                table: "PrivateMessages",
                column: "SenderId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServerParticipants_Roles_RoleId",
                table: "ServerParticipants",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChannelMessages_Users_SenderId",
                table: "ChannelMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_PrivateMessages_Users_SenderId",
                table: "PrivateMessages");

            migrationBuilder.DropForeignKey(
                name: "FK_ServerParticipants_Roles_RoleId",
                table: "ServerParticipants");

            migrationBuilder.DropIndex(
                name: "IX_PrivateMessages_SenderId",
                table: "PrivateMessages");

            migrationBuilder.DropIndex(
                name: "IX_ChannelMessages_SenderId",
                table: "ChannelMessages");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Edited",
                table: "PrivateMessages");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "PrivateMessages");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "PrivateMessages");

            migrationBuilder.DropColumn(
                name: "Edited",
                table: "ChannelMessages");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "ChannelMessages");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "ChannelMessages");

            migrationBuilder.AddForeignKey(
                name: "FK_ServerParticipants_Users_RoleId",
                table: "ServerParticipants",
                column: "RoleId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
