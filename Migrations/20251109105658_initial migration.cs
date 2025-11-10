using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFreamworkAssigment.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "reviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "products",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemsOrderItemID",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewsReviewID",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardNumber",
                table: "paymentInformation",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "TotalPrice",
                table: "orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemsOrderItemID",
                table: "orders",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemPrice",
                table: "orderItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "OrdersOrderID",
                table: "customrs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentInformationPaymentID",
                table: "customrs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewsReviewID",
                table: "customrs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShippingAddressesAddressID",
                table: "customrs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductsProductID",
                table: "categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_OrderItemsOrderItemID",
                table: "products",
                column: "OrderItemsOrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_products_ReviewsReviewID",
                table: "products",
                column: "ReviewsReviewID");

            migrationBuilder.CreateIndex(
                name: "IX_orders_OrderItemsOrderItemID",
                table: "orders",
                column: "OrderItemsOrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_customrs_OrdersOrderID",
                table: "customrs",
                column: "OrdersOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_customrs_PaymentInformationPaymentID",
                table: "customrs",
                column: "PaymentInformationPaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_customrs_ReviewsReviewID",
                table: "customrs",
                column: "ReviewsReviewID");

            migrationBuilder.CreateIndex(
                name: "IX_customrs_ShippingAddressesAddressID",
                table: "customrs",
                column: "ShippingAddressesAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_categories_ProductsProductID",
                table: "categories",
                column: "ProductsProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_products_ProductsProductID",
                table: "categories",
                column: "ProductsProductID",
                principalTable: "products",
                principalColumn: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_customrs_orders_OrdersOrderID",
                table: "customrs",
                column: "OrdersOrderID",
                principalTable: "orders",
                principalColumn: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_customrs_paymentInformation_PaymentInformationPaymentID",
                table: "customrs",
                column: "PaymentInformationPaymentID",
                principalTable: "paymentInformation",
                principalColumn: "PaymentID");

            migrationBuilder.AddForeignKey(
                name: "FK_customrs_reviews_ReviewsReviewID",
                table: "customrs",
                column: "ReviewsReviewID",
                principalTable: "reviews",
                principalColumn: "ReviewID");

            migrationBuilder.AddForeignKey(
                name: "FK_customrs_shippingAddresses_ShippingAddressesAddressID",
                table: "customrs",
                column: "ShippingAddressesAddressID",
                principalTable: "shippingAddresses",
                principalColumn: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_orderItems_OrderItemsOrderItemID",
                table: "orders",
                column: "OrderItemsOrderItemID",
                principalTable: "orderItems",
                principalColumn: "OrderItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_products_orderItems_OrderItemsOrderItemID",
                table: "products",
                column: "OrderItemsOrderItemID",
                principalTable: "orderItems",
                principalColumn: "OrderItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_products_reviews_ReviewsReviewID",
                table: "products",
                column: "ReviewsReviewID",
                principalTable: "reviews",
                principalColumn: "ReviewID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_products_ProductsProductID",
                table: "categories");

            migrationBuilder.DropForeignKey(
                name: "FK_customrs_orders_OrdersOrderID",
                table: "customrs");

            migrationBuilder.DropForeignKey(
                name: "FK_customrs_paymentInformation_PaymentInformationPaymentID",
                table: "customrs");

            migrationBuilder.DropForeignKey(
                name: "FK_customrs_reviews_ReviewsReviewID",
                table: "customrs");

            migrationBuilder.DropForeignKey(
                name: "FK_customrs_shippingAddresses_ShippingAddressesAddressID",
                table: "customrs");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_orderItems_OrderItemsOrderItemID",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_products_orderItems_OrderItemsOrderItemID",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_reviews_ReviewsReviewID",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_OrderItemsOrderItemID",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_ReviewsReviewID",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_orders_OrderItemsOrderItemID",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_customrs_OrdersOrderID",
                table: "customrs");

            migrationBuilder.DropIndex(
                name: "IX_customrs_PaymentInformationPaymentID",
                table: "customrs");

            migrationBuilder.DropIndex(
                name: "IX_customrs_ReviewsReviewID",
                table: "customrs");

            migrationBuilder.DropIndex(
                name: "IX_customrs_ShippingAddressesAddressID",
                table: "customrs");

            migrationBuilder.DropIndex(
                name: "IX_categories_ProductsProductID",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "OrderItemsOrderItemID",
                table: "products");

            migrationBuilder.DropColumn(
                name: "ReviewsReviewID",
                table: "products");

            migrationBuilder.DropColumn(
                name: "OrderItemsOrderItemID",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "OrdersOrderID",
                table: "customrs");

            migrationBuilder.DropColumn(
                name: "PaymentInformationPaymentID",
                table: "customrs");

            migrationBuilder.DropColumn(
                name: "ReviewsReviewID",
                table: "customrs");

            migrationBuilder.DropColumn(
                name: "ShippingAddressesAddressID",
                table: "customrs");

            migrationBuilder.DropColumn(
                name: "ProductsProductID",
                table: "categories");

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "reviews",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "products",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "CardNumber",
                table: "paymentInformation",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemPrice",
                table: "orderItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
