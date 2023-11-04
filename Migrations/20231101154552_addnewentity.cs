using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PLApp.Migrations
{
    /// <inheritdoc />
    public partial class addnewentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankTransaction_BankAccounts_bankAccountId",
                table: "BankTransaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankTransaction",
                table: "BankTransaction");

            migrationBuilder.RenameTable(
                name: "BankTransaction",
                newName: "BankTransactions");

            migrationBuilder.RenameIndex(
                name: "IX_BankTransaction_bankAccountId",
                table: "BankTransactions",
                newName: "IX_BankTransactions_bankAccountId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "transactionDate",
                table: "BankTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankTransactions",
                table: "BankTransactions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankTransactions_BankAccounts_bankAccountId",
                table: "BankTransactions",
                column: "bankAccountId",
                principalTable: "BankAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankTransactions_BankAccounts_bankAccountId",
                table: "BankTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankTransactions",
                table: "BankTransactions");

            migrationBuilder.RenameTable(
                name: "BankTransactions",
                newName: "BankTransaction");

            migrationBuilder.RenameIndex(
                name: "IX_BankTransactions_bankAccountId",
                table: "BankTransaction",
                newName: "IX_BankTransaction_bankAccountId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "transactionDate",
                table: "BankTransaction",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankTransaction",
                table: "BankTransaction",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankTransaction_BankAccounts_bankAccountId",
                table: "BankTransaction",
                column: "bankAccountId",
                principalTable: "BankAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
