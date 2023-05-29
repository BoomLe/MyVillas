﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_VillaAPI.Models.Dtos
{
    public class VillanumberDTO
	{
        [Required]
        public int VillaNo { set; get; }

        [Required]
        public int VillaId { set; get; }
        public string SpeciaDetails { set; get; }

		public VillaDTO Villa { get; set; }

	}
}
