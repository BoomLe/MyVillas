using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using My_VillaAPI.Models;
using My_VillaAPI.Models.Dtos;

namespace My_VillaAPI.Data
{
    public class MyDbContext : IdentityDbContext<ApplicationUser>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { set; get;}
        public DbSet<LocalUser> LocalUsers { set; get; }
        public DbSet<Villa> Villas {set;get;}
        public DbSet<VillaNumber> VillaNumbers { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
                
                new Villa 
                {
                    Id = 1,
                    Name = "Azura Gold Hotel & Apartment",
                    Details = @"Nằm cách Bãi biển Nha Trang chưa đầy 100 m, Azura Gold Hotel & Apartment cung cấp phòng nghỉ 
                              nhìn ra biển. Chỗ nghỉ này có bàn đặt tour, lễ tân 24 giờ và WiFi miễn phí 
                              Trung tâm Thuyền buồm Việt Nam và Quảng trường chính đều nằm trong bán kính 200 m từ khách sạn. Sân bay Nha Trang cách đó 26 km.
                              Phòng nghỉ tại đây có TV truyền hình cáp, minibar và phòng tắm riêng với tiện nghi vòi sen cùng đồ vệ sinh cá nhân. Một số phòng được trang bị bồn tắm.",
                    ImageUrl = "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/azura.jpg",
                    Occupancy = 4,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    UpdateDate = DateTime.Now
                },

                new Villa
                {
                    Id = 2,
                    Name = "Apus Hotel",
                    Details = @"Tọa lạc tại thành phố Nha Trang, cách Trung tâm Thuyền buồm Việt Nam 
                              200 m, Apus Hotel cung cấp chỗ ở thoải mái và có hồ bơi ngoài trời cũng 
                              như nhà hàng. Khách sạn cung cấp Wi-Fi miễn phí trong toàn bộ tòa nhà, 
                              đồng thời có quầy lễ tân 24 giờ.Các phòng máy lạnh được bài trí trang 
                              nhã tại đây có TV truyền hình cáp, két an toàn (trong phòng), ấm đung nước điện và minibar. 
                              Các phòng tắm riêng đi kèm bồn tắm hoặc tiện nghi vòi sen, máy sấy tóc và đồ vệ sinh cá nhân miễn phí. 
                              phòng cho tầm nhìn ra quang cảnh thành phố.",
                    ImageUrl = "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/apus.jpg",
                    Occupancy = 4,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    UpdateDate = DateTime.Now
                },

                new Villa
                {
                    Id = 3,
                    Name = "La Sera Hotel",
                    Details = @"Nằm trong bán kính 30 m từ Bãi biển Nha Trang, khách sạn La Sera Hotel
                                ở thành phố Nha Trang này có tầm nhìn ra toàn cảnh từ quán sky pool bar. Du khách có thể dùng bữa 
                                tại nhà hàng ngay trong khuôn viên.
                                Mỗi phòng nghỉ theo phong cách hiện đại tại khách sạn này đều có khu vực tiếp khách, 
                                màn hình phẳng với các kênh truyền hình cáp và phòng tắm riêng. Một số phòng nhìn ra quang cảnh 
                                bãi biển, thành phố hoặc núi non.",
                    ImageUrl = "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/sera.jpg",
                    Occupancy = 4,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    UpdateDate = DateTime.Now
                },

                new Villa
                {
                    Id = 4,
                    Name = "Regalia Nha Trang",
                    Details = @"Tọa lạc dọc theo bờ biển, Regalia Nha Trang cung cấp chỗ nghỉ hiện đại
                                và trang nhã với Wi-Fi miễn phí trong toàn bộ khuôn viên. 
                                khách sạn này nằm cách Trung tâm thuyền buồm Việt Nam khoảng 800 m trong
                                khi du khách đi bộ 3 phút là đến Bãi biển Nha Trang.",
                    ImageUrl = "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/regalia.jpg",
                    Occupancy = 4,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    UpdateDate = DateTime.Now
                },
                new Villa
                {
                    Id = 5,
                    Name = "Crown Hotel Nha Trang",
                    Details = @"Phòng nghỉ gắn máy điều hòa tại Crown Hotel Nha Trang có bàn làm việc,
                                ấm đun nước, tủ lạnh, minibar, két an toàn,
                                TV màn hình phẳng, sân hiên, ban công và phòng tắm riêng với vòi xịt chậu rửa vệ sinh.
                                Một số phòng nhìn ra quang cảnh thành phố. Các phòng được trang bị ga trải giường và khăn tắm.",
                    ImageUrl = "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/crown.jpg",
                    Occupancy = 4,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    UpdateDate = DateTime.Now
                },
                new Villa
                {
                    Id = 6,
                    Name = "Majestic Premium Hotel",
                    Details = @"Tọa lạc tại thành phố Nha Trang, Majestic Premium Hotel có hồ bơi ngoài trời, 
                                trung tâm thể dục, sảnh khách chung, nhà hàng và quầy bar. Khách sạn 4 sao này cung cấp phòng nghỉ 
                                gắn máy điều hòa với WiFi miễn phí. Chỗ nghỉ cung cấp dịch vụ phòng, dịch vụ lễ tân 24 giờ và dịch vụ 
                                thu đổi ngoại tệ cho khách.",
                    ImageUrl = "https://fruitrestaurant.blob.core.windows.net/travel/Traviel/majestic.jpg",
                    Occupancy = 4,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    UpdateDate = DateTime.Now
                }
                );
        }

    }
}
