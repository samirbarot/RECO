using Microsoft.EntityFrameworkCore.Migrations;

namespace RECO.Data.Migrations
{
    public partial class AddUniqueKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pages_DocumentID",
                table: "Pages");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_DocumentID_OriginalPageNumber",
                table: "Pages",
                columns: new[] { "DocumentID", "OriginalPageNumber" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pages_DocumentID_OriginalPageNumber",
                table: "Pages");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_DocumentID",
                table: "Pages",
                column: "DocumentID");
        }
    }
}
