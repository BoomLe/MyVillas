using My_VillaWeb.Models.ApiHttp;

namespace My_VillaWeb.Services.IServices
{
    public interface IBaseService
    {
        APIResponse responseModel { set; get; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
