using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_VillaAPI.Models
{
    public class VillaNumber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VillaNo { set; get; }

	
        public string SpeciaDetails { set; get; }

        public DateTime CreateDate { set; get; }

        public DateTime UpdateDate { set; get; }

		[ForeignKey("Villa")]
		public int VillaId { set; get; }

		public Villa Villa { set; get; }
	}
}
