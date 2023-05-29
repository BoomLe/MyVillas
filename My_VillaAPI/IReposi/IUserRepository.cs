using My_VillaAPI.Models;
using My_VillaAPI.Models.Dtos;

namespace My_VillaAPI.IReposi
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);

        Task<UserDTO> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
