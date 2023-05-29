using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_VillaAPI.ApiRespon;
using My_VillaAPI.Data;
using My_VillaAPI.IRespo;
using My_VillaAPI.Models;
using My_VillaAPI.Models.Dtos;
using System.Data;
using System.Net;

namespace My_VillaAPI.Controllers.Ver2
{
    [Route("api/v{version:apiVersion}/VillaAPINumber")]
    [ApiController]
    [ApiVersion("2.0")]


    public class VillaAPINumberController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IRepositoryVillaNumber _dbVillaNumber;
        private readonly IRepositoryVilla _dbVilla;
        private readonly IMapper _mapper;
        public VillaAPINumberController(IRepositoryVillaNumber dbVillaNumber, IMapper mapper,
            IRepositoryVilla dbVilla)
        {
            _dbVillaNumber = dbVillaNumber;
            _mapper = mapper;
            _response = new();
            _dbVilla = dbVilla;
        }

        //[MapToApiVersion("2.0")]
        [HttpGet("GetString")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hoàng Tuấn", "Gomesle1998@icloud.com" };
        }




    }
}
