using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShipmentСoterie.Migrations
{
    /// <inheritdoc />
    public partial class editTablesId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_orderStatus_statusid",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_order_payMethod_payMethodid",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_orderList_product_productid",
                table: "orderList");

            migrationBuilder.DropForeignKey(
                name: "FK_product_productType_typeid",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_user_profile_profileid",
                table: "user");

            migrationBuilder.RenameColumn(
                name: "profileid",
                table: "user",
                newName: "profileId");

            migrationBuilder.RenameIndex(
                name: "IX_user_profileid",
                table: "user",
                newName: "IX_user_profileId");

            migrationBuilder.RenameColumn(
                name: "typeid",
                table: "product",
                newName: "typeId");

            migrationBuilder.RenameIndex(
                name: "IX_product_typeid",
                table: "product",
                newName: "IX_product_typeId");

            migrationBuilder.RenameColumn(
                name: "productid",
                table: "orderList",
                newName: "productId");

            migrationBuilder.RenameIndex(
                name: "IX_orderList_productid",
                table: "orderList",
                newName: "IX_orderList_productId");

            migrationBuilder.RenameColumn(
                name: "statusid",
                table: "order",
                newName: "statusId");

            migrationBuilder.RenameColumn(
                name: "payMethodid",
                table: "order",
                newName: "payMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_order_statusid",
                table: "order",
                newName: "IX_order_statusId");

            migrationBuilder.RenameIndex(
                name: "IX_order_payMethodid",
                table: "order",
                newName: "IX_order_payMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_order_orderStatus_statusId",
                table: "order",
                column: "statusId",
                principalTable: "orderStatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_payMethod_payMethodId",
                table: "order",
                column: "payMethodId",
                principalTable: "payMethod",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderList_product_productId",
                table: "orderList",
                column: "productId",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_productType_typeId",
                table: "product",
                column: "typeId",
                principalTable: "productType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_profile_profileId",
                table: "user",
                column: "profileId",
                principalTable: "profile",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_orderStatus_statusId",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_order_payMethod_payMethodId",
                table: "order");

            migrationBuilder.DropForeignKey(
                name: "FK_orderList_product_productId",
                table: "orderList");

            migrationBuilder.DropForeignKey(
                name: "FK_product_productType_typeId",
                table: "product");

            migrationBuilder.DropForeignKey(
                name: "FK_user_profile_profileId",
                table: "user");

            migrationBuilder.RenameColumn(
                name: "profileId",
                table: "user",
                newName: "profileid");

            migrationBuilder.RenameIndex(
                name: "IX_user_profileId",
                table: "user",
                newName: "IX_user_profileid");

            migrationBuilder.RenameColumn(
                name: "typeId",
                table: "product",
                newName: "typeid");

            migrationBuilder.RenameIndex(
                name: "IX_product_typeId",
                table: "product",
                newName: "IX_product_typeid");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "orderList",
                newName: "productid");

            migrationBuilder.RenameIndex(
                name: "IX_orderList_productId",
                table: "orderList",
                newName: "IX_orderList_productid");

            migrationBuilder.RenameColumn(
                name: "statusId",
                table: "order",
                newName: "statusid");

            migrationBuilder.RenameColumn(
                name: "payMethodId",
                table: "order",
                newName: "payMethodid");

            migrationBuilder.RenameIndex(
                name: "IX_order_statusId",
                table: "order",
                newName: "IX_order_statusid");

            migrationBuilder.RenameIndex(
                name: "IX_order_payMethodId",
                table: "order",
                newName: "IX_order_payMethodid");

            migrationBuilder.AddForeignKey(
                name: "FK_order_orderStatus_statusid",
                table: "order",
                column: "statusid",
                principalTable: "orderStatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_payMethod_payMethodid",
                table: "order",
                column: "payMethodid",
                principalTable: "payMethod",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderList_product_productid",
                table: "orderList",
                column: "productid",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_productType_typeid",
                table: "product",
                column: "typeid",
                principalTable: "productType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_profile_profileid",
                table: "user",
                column: "profileid",
                principalTable: "profile",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
