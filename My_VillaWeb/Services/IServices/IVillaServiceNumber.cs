using My_VillaWeb.Models.Dtos;

namespace My_VillaWeb.Services.IServices
{
    public interface IVillaServiceNumber
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id, string token);

        Task<T> CreateAsync<T>(VillanumberCreateDTO createVillasDTO, string token);
        Task<T> UpdateAsync<T>(VillanumberUpdateDTO updateVillasDTO, string token);
        Task<T> DeleteAsync<T>(int id, string token);
    }
}
