using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace My_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeekProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreateDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nằm cách Bãi biển Nha Trang chưa đầy 100 m, Azura Gold Hotel & Apartment cung cấp phòng nghỉ \r\n                              nhìn ra biển. Chỗ nghỉ này có bàn đặt tour, lễ tân 24 giờ và WiFi miễn phí \r\n                              Trung tâm Thuyền buồm Việt Nam và Quảng trường chính đều nằm trong bán kính 200 m từ khách sạn. Sân bay Nha Trang cách đó 26 km.\r\n                              Phòng nghỉ tại đây có TV truyền hình cáp, minibar và phòng tắm riêng với tiện nghi vòi sen cùng đồ vệ sinh cá nhân. Một số phòng được trang bị bồn tắm.", "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/azura.jpg", "Azura Gold Hotel & Apartment", 4, 200.0, 550, new DateTime(2023, 5, 25, 12, 8, 52, 840, DateTimeKind.Local).AddTicks(9481) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tọa lạc tại thành phố Nha Trang, cách Trung tâm Thuyền buồm Việt Nam \r\n                              200 m, Apus Hotel cung cấp chỗ ở thoải mái và có hồ bơi ngoài trời cũng \r\n                              như nhà hàng. Khách sạn cung cấp Wi-Fi miễn phí trong toàn bộ tòa nhà, \r\n                              đồng thời có quầy lễ tân 24 giờ.Các phòng máy lạnh được bài trí trang \r\n                              nhã tại đây có TV truyền hình cáp, két an toàn (trong phòng), ấm đung nước điện và minibar. \r\n                              Các phòng tắm riêng đi kèm bồn tắm hoặc tiện nghi vòi sen, máy sấy tóc và đồ vệ sinh cá nhân miễn phí. \r\n                              phòng cho tầm nhìn ra quang cảnh thành phố.", "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/apus.jpg", "Apus Hotel", 4, 200.0, 550, new DateTime(2023, 5, 25, 12, 8, 52, 840, DateTimeKind.Local).AddTicks(9493) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nằm trong bán kính 30 m từ Bãi biển Nha Trang, khách sạn La Sera Hotel\r\n                                ở thành phố Nha Trang này có tầm nhìn ra toàn cảnh từ quán sky pool bar. Du khách có thể dùng bữa \r\n                                tại nhà hàng ngay trong khuôn viên.\r\n                                Mỗi phòng nghỉ theo phong cách hiện đại tại khách sạn này đều có khu vực tiếp khách, \r\n                                màn hình phẳng với các kênh truyền hình cáp và phòng tắm riêng. Một số phòng nhìn ra quang cảnh \r\n                                bãi biển, thành phố hoặc núi non.", "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/sera.jpg", "La Sera Hotel", 4, 200.0, 550, new DateTime(2023, 5, 25, 12, 8, 52, 840, DateTimeKind.Local).AddTicks(9495) },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tọa lạc dọc theo bờ biển, Regalia Nha Trang cung cấp chỗ nghỉ hiện đại\r\n                                và trang nhã với Wi-Fi miễn phí trong toàn bộ khuôn viên. \r\n                                khách sạn này nằm cách Trung tâm thuyền buồm Việt Nam khoảng 800 m trong\r\n                                khi du khách đi bộ 3 phút là đến Bãi biển Nha Trang.", "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/regalia.jpg", "Regalia Nha Trang", 4, 200.0, 550, new DateTime(2023, 5, 25, 12, 8, 52, 840, DateTimeKind.Local).AddTicks(9496) },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phòng nghỉ gắn máy điều hòa tại Crown Hotel Nha Trang có bàn làm việc,\r\n                                ấm đun nước, tủ lạnh, minibar, két an toàn,\r\n                                TV màn hình phẳng, sân hiên, ban công và phòng tắm riêng với vòi xịt chậu rửa vệ sinh.\r\n                                Một số phòng nhìn ra quang cảnh thành phố. Các phòng được trang bị ga trải giường và khăn tắm.", "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/crown.jpg", "Crown Hotel Nha Trang", 4, 200.0, 550, new DateTime(2023, 5, 25, 12, 8, 52, 840, DateTimeKind.Local).AddTicks(9498) },
                    { 6, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tọa lạc tại thành phố Nha Trang, Majestic Premium Hotel có hồ bơi ngoài trời, \r\n                                trung tâm thể dục, sảnh khách chung, nhà hàng và quầy bar. Khách sạn 4 sao này cung cấp phòng nghỉ \r\n                                gắn máy điều hòa với WiFi miễn phí. Chỗ nghỉ cung cấp dịch vụ phòng, dịch vụ lễ tân 24 giờ và dịch vụ \r\n                                thu đổi ngoại tệ cho khách.", "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/majestic.jpg", "Majestic Premium Hotel", 4, 200.0, 550, new DateTime(2023, 5, 25, 12, 8, 52, 840, DateTimeKind.Local).AddTicks(9500) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
