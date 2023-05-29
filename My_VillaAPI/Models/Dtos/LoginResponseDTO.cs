namespace My_VillaAPI.Models.Dtos
{
    public class LoginResponseDTO
    {
        public UserDTO User { set; get; }
    
        public string Token { set; get; }
    }
}
