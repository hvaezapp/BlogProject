using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class edit_desc_col_posttbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desription",
                table: "TblPost",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "TblPost",
                newName: "Desription");
        }
    }
}
