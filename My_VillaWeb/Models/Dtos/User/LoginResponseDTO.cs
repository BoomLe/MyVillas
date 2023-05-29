using My_VillaWeb.Models.Dtos.User;

namespace My_VillaWeb.Models.Dtos
{
    public class LoginResponseDTO
    {
        public UserDTO User { set; get; }
        public string Token { set; get; }
    }
}
