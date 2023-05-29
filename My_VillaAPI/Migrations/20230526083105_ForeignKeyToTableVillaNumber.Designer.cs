﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using My_VillaAPI.Data;

#nullable disable

namespace My_VillaAPI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230526083105_ForeignKeyToTableVillaNumber")]
    partial class ForeignKeyToTableVillaNumber
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("My_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Nằm cách Bãi biển Nha Trang chưa đầy 100 m, Azura Gold Hotel & Apartment cung cấp phòng nghỉ \r\n                              nhìn ra biển. Chỗ nghỉ này có bàn đặt tour, lễ tân 24 giờ và WiFi miễn phí \r\n                              Trung tâm Thuyền buồm Việt Nam và Quảng trường chính đều nằm trong bán kính 200 m từ khách sạn. Sân bay Nha Trang cách đó 26 km.\r\n                              Phòng nghỉ tại đây có TV truyền hình cáp, minibar và phòng tắm riêng với tiện nghi vòi sen cùng đồ vệ sinh cá nhân. Một số phòng được trang bị bồn tắm.",
                            ImageUrl = "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/azura.jpg",
                            Name = "Azura Gold Hotel & Apartment",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 5, 26, 15, 31, 5, 233, DateTimeKind.Local).AddTicks(4227)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Tọa lạc tại thành phố Nha Trang, cách Trung tâm Thuyền buồm Việt Nam \r\n                              200 m, Apus Hotel cung cấp chỗ ở thoải mái và có hồ bơi ngoài trời cũng \r\n                              như nhà hàng. Khách sạn cung cấp Wi-Fi miễn phí trong toàn bộ tòa nhà, \r\n                              đồng thời có quầy lễ tân 24 giờ.Các phòng máy lạnh được bài trí trang \r\n                              nhã tại đây có TV truyền hình cáp, két an toàn (trong phòng), ấm đung nước điện và minibar. \r\n                              Các phòng tắm riêng đi kèm bồn tắm hoặc tiện nghi vòi sen, máy sấy tóc và đồ vệ sinh cá nhân miễn phí. \r\n                              phòng cho tầm nhìn ra quang cảnh thành phố.",
                            ImageUrl = "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/apus.jpg",
                            Name = "Apus Hotel",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 5, 26, 15, 31, 5, 233, DateTimeKind.Local).AddTicks(4252)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Nằm trong bán kính 30 m từ Bãi biển Nha Trang, khách sạn La Sera Hotel\r\n                                ở thành phố Nha Trang này có tầm nhìn ra toàn cảnh từ quán sky pool bar. Du khách có thể dùng bữa \r\n                                tại nhà hàng ngay trong khuôn viên.\r\n                                Mỗi phòng nghỉ theo phong cách hiện đại tại khách sạn này đều có khu vực tiếp khách, \r\n                                màn hình phẳng với các kênh truyền hình cáp và phòng tắm riêng. Một số phòng nhìn ra quang cảnh \r\n                                bãi biển, thành phố hoặc núi non.",
                            ImageUrl = "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/sera.jpg",
                            Name = "La Sera Hotel",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 5, 26, 15, 31, 5, 233, DateTimeKind.Local).AddTicks(4255)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Tọa lạc dọc theo bờ biển, Regalia Nha Trang cung cấp chỗ nghỉ hiện đại\r\n                                và trang nhã với Wi-Fi miễn phí trong toàn bộ khuôn viên. \r\n                                khách sạn này nằm cách Trung tâm thuyền buồm Việt Nam khoảng 800 m trong\r\n                                khi du khách đi bộ 3 phút là đến Bãi biển Nha Trang.",
                            ImageUrl = "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/regalia.jpg",
                            Name = "Regalia Nha Trang",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 5, 26, 15, 31, 5, 233, DateTimeKind.Local).AddTicks(4257)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Phòng nghỉ gắn máy điều hòa tại Crown Hotel Nha Trang có bàn làm việc,\r\n                                ấm đun nước, tủ lạnh, minibar, két an toàn,\r\n                                TV màn hình phẳng, sân hiên, ban công và phòng tắm riêng với vòi xịt chậu rửa vệ sinh.\r\n                                Một số phòng nhìn ra quang cảnh thành phố. Các phòng được trang bị ga trải giường và khăn tắm.",
                            ImageUrl = "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/crown.jpg",
                            Name = "Crown Hotel Nha Trang",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 5, 26, 15, 31, 5, 233, DateTimeKind.Local).AddTicks(4260)
                        },
                        new
                        {
                            Id = 6,
                            Amenity = "",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Details = "Tọa lạc tại thành phố Nha Trang, Majestic Premium Hotel có hồ bơi ngoài trời, \r\n                                trung tâm thể dục, sảnh khách chung, nhà hàng và quầy bar. Khách sạn 4 sao này cung cấp phòng nghỉ \r\n                                gắn máy điều hòa với WiFi miễn phí. Chỗ nghỉ cung cấp dịch vụ phòng, dịch vụ lễ tân 24 giờ và dịch vụ \r\n                                thu đổi ngoại tệ cho khách.",
                            ImageUrl = "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/majestic.jpg",
                            Name = "Majestic Premium Hotel",
                            Occupancy = 4,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(2023, 5, 26, 15, 31, 5, 233, DateTimeKind.Local).AddTicks(4263)
                        });
                });

            modelBuilder.Entity("My_VillaAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpeciaDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("My_VillaAPI.Models.VillaNumber", b =>
                {
                    b.HasOne("My_VillaAPI.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
