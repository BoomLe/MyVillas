using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_VillaAPI.Models.Dtos
{
    public class CreateVillasDTO
    {
   
        [Required]
        [MaxLength(30)]
        public string Name { set; get; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(1000)]
        public string Details { set; get; }
        [Required]
        public double Rate { set; get; }
     
        public int Occupancy { set; get; }
   
        public int Sqft { set; get; }
    
        public string ImageUrl { set; get; }

        public string Amenity { set; get; }

    }
}
