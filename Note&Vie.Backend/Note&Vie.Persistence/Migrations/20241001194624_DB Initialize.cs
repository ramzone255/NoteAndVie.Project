using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Note_Vie.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DBInitialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client_Type",
                columns: table => new
                {
                    id_client_type = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    discount = table.Column<double>(type: "float", nullable: false),
                    client_type_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Type", x => x.id_client_type);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    id_post = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    post_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.id_post);
                });

            migrationBuilder.CreateTable(
                name: "Product_Status",
                columns: table => new
                {
                    id_product_status = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_status_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Status", x => x.id_product_status);
                });

            migrationBuilder.CreateTable(
                name: "Product_Type",
                columns: table => new
                {
                    id_product_type = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_type_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Type", x => x.id_product_type);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id_client = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    client_mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    id_client_type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.id_client);
                    table.ForeignKey(
                        name: "FK_Client_Client_Type_id_client_type",
                        column: x => x.id_client_type,
                        principalTable: "Client_Type",
                        principalColumn: "id_client_type",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id_employees = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employees_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    id_post = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id_employees);
                    table.ForeignKey(
                        name: "FK_Employees_Post_id_post",
                        column: x => x.id_post,
                        principalTable: "Post",
                        principalColumn: "id_post",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    id_product = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    product_description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    product_price = table.Column<double>(type: "float", nullable: false),
                    product_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_product_status = table.Column<int>(type: "int", nullable: false),
                    id_product_type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id_product);
                    table.ForeignKey(
                        name: "FK_Product_Product_Status_id_product_status",
                        column: x => x.id_product_status,
                        principalTable: "Product_Status",
                        principalColumn: "id_product_status",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Product_Type_id_product_type",
                        column: x => x.id_product_type,
                        principalTable: "Product_Type",
                        principalColumn: "id_product_type",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    id_receipt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_client = table.Column<int>(type: "int", nullable: false),
                    id_employees = table.Column<int>(type: "int", nullable: false),
                    id_product = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.id_receipt);
                    table.ForeignKey(
                        name: "FK_Receipt_Client_id_client",
                        column: x => x.id_client,
                        principalTable: "Client",
                        principalColumn: "id_client",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receipt_Employees_id_employees",
                        column: x => x.id_employees,
                        principalTable: "Employees",
                        principalColumn: "id_employees",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receipt_Product_id_product",
                        column: x => x.id_product,
                        principalTable: "Product",
                        principalColumn: "id_product",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_id_client",
                table: "Client",
                column: "id_client",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_id_client_type",
                table: "Client",
                column: "id_client_type");

            migrationBuilder.CreateIndex(
                name: "IX_Client_Type_id_client_type",
                table: "Client_Type",
                column: "id_client_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_id_employees",
                table: "Employees",
                column: "id_employees",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_id_post",
                table: "Employees",
                column: "id_post");

            migrationBuilder.CreateIndex(
                name: "IX_Post_id_post",
                table: "Post",
                column: "id_post",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_id_product",
                table: "Product",
                column: "id_product",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_id_product_status",
                table: "Product",
                column: "id_product_status");

            migrationBuilder.CreateIndex(
                name: "IX_Product_id_product_type",
                table: "Product",
                column: "id_product_type");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Status_id_product_status",
                table: "Product_Status",
                column: "id_product_status",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_Type_id_product_type",
                table: "Product_Type",
                column: "id_product_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_id_client",
                table: "Receipt",
                column: "id_client");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_id_employees",
                table: "Receipt",
                column: "id_employees");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_id_product",
                table: "Receipt",
                column: "id_product");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_id_receipt",
                table: "Receipt",
                column: "id_receipt",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipt");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Client_Type");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Product_Status");

            migrationBuilder.DropTable(
                name: "Product_Type");
        }
    }
}
