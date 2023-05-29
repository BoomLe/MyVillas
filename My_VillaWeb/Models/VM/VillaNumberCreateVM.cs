using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using My_VillaWeb.Models.Dtos;

namespace My_VillaWeb.Models.VM
{
    public class VillaNumberCreateVM
    {
        public VillaNumberCreateVM()
        {
            VillaNumber = new VillanumberCreateDTO();
            
        }
        public VillanumberCreateDTO VillaNumber { set; get; }

        [ValidateNever]
        public IEnumerable<SelectListItem> VillaList { set; get; }
    }
}
