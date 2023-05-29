using My_VillaUtility;
using My_VillaWeb.Models.ApiHttp;
using My_VillaWeb.Models.Dtos;
using My_VillaWeb.Services.IServices;
using Newtonsoft.Json.Linq;
using NuGet.Common;

namespace My_VillaWeb.Services
{
    public class VillaServiceNumber : BaseService, IVillaServiceNumber
    {
        private readonly IHttpClientFactory _httpClient;
        private string villaUrl;
        public VillaServiceNumber(IHttpClientFactory httpClient, IConfiguration configuration) : base(httpClient)
        {
            _httpClient = httpClient;
            villaUrl = configuration.GetValue<string>("serviceUrls:VillaAPI");
        }
        public Task<T> CreateAsync<T>(VillanumberCreateDTO createVillasDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = createVillasDTO,
                Url = villaUrl + "/api/v1/VillaAPINumber",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
         

            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = villaUrl + "/api/v1/VillaAPINumber/" + id,
                Token = token

            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
              
                Url = villaUrl + "/api/v1/VillaAPINumber",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
              
                Url = villaUrl + "/api/v1/VillaAPINumber/" + id,
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(VillanumberUpdateDTO updateVillasDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = updateVillasDTO,
                Url = villaUrl + "/api/v1/VillaAPINumber/" + updateVillasDTO.VillaNo,
                Token = token
            });
        }
    }
}
