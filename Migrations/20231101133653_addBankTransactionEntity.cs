using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PLApp.Migrations
{
    /// <inheritdoc />
    public partial class addBankTransactionEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transactionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    transactionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documentCategory = table.Column<int>(type: "int", nullable: false),
                    voucherNumber = table.Column<int>(type: "int", nullable: false),
                    recipientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recipientAccountNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    outwardAmount = table.Column<double>(type: "float", nullable: false),
                    inwardAmount = table.Column<double>(type: "float", nullable: false),
                    bankAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankTransaction_BankAccounts_bankAccountId",
                        column: x => x.bankAccountId,
                        principalTable: "BankAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankTransaction_bankAccountId",
                table: "BankTransaction",
                column: "bankAccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankTransaction");
        }
    }
}
