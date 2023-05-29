using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using My_VillaUtility;
using My_VillaWeb.Models;
using My_VillaWeb.Models.ApiHttp;
using My_VillaWeb.Models.Dtos;
using My_VillaWeb.Services.IServices;
using Newtonsoft.Json;
using System.Diagnostics;

namespace My_VillaWeb.Controllers
{
    public class HomeController : Controller
    {
		private readonly IVillaService _villaService;
		private readonly IMapper _mapper;
		public HomeController(IVillaService villaService, IMapper mapper)
		{
			_mapper = mapper;
			_villaService = villaService;
		}

		public async Task<IActionResult> Index()
		{
			List<VillaDTO> list = new();

			var response = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
			if (response != null && response.IsSuccess)
			{
				list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
			}

			return View(list);
		}
	}
}