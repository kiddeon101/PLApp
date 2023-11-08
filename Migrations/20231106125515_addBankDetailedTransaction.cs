using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PLApp.Migrations
{
    /// <inheritdoc />
    public partial class addBankDetailedTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankDetailedTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: false),
                    isIncomming = table.Column<bool>(type: "bit", nullable: false),
                    accountYear = table.Column<int>(type: "int", nullable: false),
                    accountMonth = table.Column<int>(type: "int", nullable: false),
                    customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projectNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    invoiceNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    purchaseOrderNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankTransactionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankDetailedTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankDetailedTransactions_BankTransactions_BankTransactionId",
                        column: x => x.BankTransactionId,
                        principalTable: "BankTransactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankDetailedTransactions_BankTransactionId",
                table: "BankDetailedTransactions",
                column: "BankTransactionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankDetailedTransactions");
        }
    }
}
