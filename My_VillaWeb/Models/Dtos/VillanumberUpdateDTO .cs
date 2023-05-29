using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_VillaWeb.Models.Dtos
{
    public class VillanumberUpdateDTO
	{
        [Required]
        public int VillaNo { set; get; }

        [Required]
        public int VillaId { set; get; }
        public string SpeciaDetails { set; get; }

    }
}
