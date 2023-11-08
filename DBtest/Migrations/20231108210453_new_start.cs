using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBtest.Migrations
{
    /// <inheritdoc />
    public partial class new_start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prod_Name",
                table: "Prods",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Prod_Image",
                table: "Prods",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "Prod_Description",
                table: "Prods",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Bulet_Id",
                table: "Bukets",
                newName: "Buket_Id");

            migrationBuilder.AddColumn<string>(
                name: "Cost",
                table: "Prods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Book_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Book_Id);
                });

            migrationBuilder.CreateTable(
                name: "BookProds",
                columns: table => new
                {
                    Prod_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book_Id = table.Column<int>(type: "int", nullable: false),
                    Prod_Id1 = table.Column<int>(type: "int", nullable: false),
                    Book_Id1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookProds", x => x.Prod_Id);
                    table.ForeignKey(
                        name: "FK_BookProds_Books_Book_Id1",
                        column: x => x.Book_Id1,
                        principalTable: "Books",
                        principalColumn: "Book_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookProds_Prods_Prod_Id1",
                        column: x => x.Prod_Id1,
                        principalTable: "Prods",
                        principalColumn: "Prod_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookProds_Book_Id1",
                table: "BookProds",
                column: "Book_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_BookProds_Prod_Id1",
                table: "BookProds",
                column: "Prod_Id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookProds");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Prods");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Prods",
                newName: "Prod_Name");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Prods",
                newName: "Prod_Image");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Prods",
                newName: "Prod_Description");

            migrationBuilder.RenameColumn(
                name: "Buket_Id",
                table: "Bukets",
                newName: "Bulet_Id");
        }
    }
}
