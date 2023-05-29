using My_VillaWeb.Models.Dtos;

namespace My_VillaWeb.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id, string token);

        Task<T> CreateAsync<T>(CreateVillasDTO createVillasDTO, string token);
        Task<T> UpdateAsync<T>(UpdateVillasDTO updateVillasDTO, string token);
        Task<T> DeleteAsync<T>(int id, string token);
    }
}
