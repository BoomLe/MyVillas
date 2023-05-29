using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using My_VillaWeb.Models.Dtos;

namespace My_VillaWeb.Models.VM
{
    public class VillaNumberDeleteVM
    {
        public VillaNumberDeleteVM()
        {
            VillaNumber = new VillanumberDTO();
            
        }
        public VillanumberDTO VillaNumber { set; get; }

        [ValidateNever]
        public IEnumerable<SelectListItem> VillaList { set; get; }
    }
}
