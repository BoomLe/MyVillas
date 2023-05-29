using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using My_VillaUtility;
using My_VillaWeb.Models.ApiHttp;
using My_VillaWeb.Models.Dtos;
using My_VillaWeb.Services.IServices;
using Newtonsoft.Json;
using System.Drawing;

namespace My_VillaWeb.Controllers
{
    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;
        public VillaController(IVillaService villaService, IMapper mapper)
        {
            _mapper = mapper;
            _villaService = villaService;
        }

		public async Task<IActionResult> IndexVilla()
		{
			List<VillaDTO> list = new ();

			var response = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
			if (response != null && response.IsSuccess)
			{
				list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
			}
		
			return View(list);
		}
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CreateVilla() 
		{
			return View();
		}

        [Authorize(Roles = "admin")]
        [HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> CreateVilla(CreateVillasDTO createVillasDTO) 
		{
			if (ModelState.IsValid) 
			{
				var respon = await _villaService.CreateAsync<APIResponse>(createVillasDTO, HttpContext.Session.GetString(SD.SessionToken));
				if(respon != null && respon.IsSuccess) 
				{
					TempData["success"] = "Tạo booking villa thành công !";
					return RedirectToAction(nameof(IndexVilla));
				}

			
			}
            TempData["error"] = "Lỗi không thể tạo mới booking villa ! ";
            return View(createVillasDTO);
		}

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdateVilla(int villaId) 
		{
			var respon = await _villaService.GetAsync<APIResponse>(villaId, HttpContext.Session.GetString(SD.SessionToken));
			if(respon != null && respon.IsSuccess) 
			{
				

                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(respon.Result));
				return View(_mapper.Map<UpdateVillasDTO>(model));
			}
			return NotFound();
		}
        [Authorize(Roles = "admin")]
        [HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> UpdateVilla(UpdateVillasDTO updateVillasDTO) 
		{
			if (ModelState.IsValid) 
			{
				var respon = await _villaService.UpdateAsync<APIResponse>(updateVillasDTO, HttpContext.Session.GetString(SD.SessionToken));
				if(respon != null && respon.IsSuccess) 
				{
                    TempData["success"] = "Chỉnh sửa booking villa thành công ! ";
                    return RedirectToAction(nameof(IndexVilla));
				}
			}
            TempData["error"] = "Lỗi không thể chỉnh sửa booking villa ! ";
            return View(updateVillasDTO);
		}
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteVilla(int villaId) 
		{
            var response = await _villaService.GetAsync<APIResponse>(villaId, HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteVilla(VillaDTO model) 
		{
		
                var response = await _villaService.DeleteAsync<APIResponse>(model.Id, HttpContext.Session.GetString(SD.SessionToken));
                if (response != null && response.IsSuccess)
                {
                TempData["success"] = "Xóa booking villa thành công ! ";
                return RedirectToAction(nameof(IndexVilla));
                }

            TempData["error"] = "Lỗi không thể xóa booking villa ! ";

            return View(model);
        }

	}
}
