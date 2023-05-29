using My_VillaUtility;
using My_VillaWeb.Models.ApiHttp;
using My_VillaWeb.Models.Dtos;
using My_VillaWeb.Services.IServices;
using NuGet.Common;

namespace My_VillaWeb.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _httpClient;
        private string villaUrl;
        public VillaService(IHttpClientFactory httpClient, IConfiguration configuration) : base(httpClient)
        {
            _httpClient = httpClient;
            villaUrl = configuration.GetValue<string>("serviceUrls:VillaAPI");
        }
        public Task<T> CreateAsync<T>(CreateVillasDTO createVillasDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = createVillasDTO,
                Url = villaUrl + "/api/v1/VillaAPI",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
         

            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = villaUrl + "/api/v1/VillaAPI/" + id,
                Token = token

            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
              
                Url = villaUrl + "/api/v1/VillaAPI",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
              
                Url = villaUrl + "/api/v1/VillaAPI/"+ id,
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(UpdateVillasDTO updateVillasDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = updateVillasDTO,
                Url = villaUrl + "/api/v1/VillaAPI/" + updateVillasDTO.Id,
                Token =token
            });
        }
    }
}
