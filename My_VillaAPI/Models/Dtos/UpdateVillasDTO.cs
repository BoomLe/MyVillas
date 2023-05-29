using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_VillaAPI.Models.Dtos
{
    public class UpdateVillasDTO
	{
        [Required]
        public int Id { set; get; }
       
        [MaxLength(30)]
        public string Name { set; get; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(1000)]
        public string Details { set; get; }
       
        public double Rate { set; get; }
    
        public int Occupancy { set; get; }
        
       
        public string ImageUrl { set; get; }

        public string Amenity { set; get; }

    }
}
