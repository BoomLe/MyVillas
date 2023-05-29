using System.Net;

namespace My_VillaAPI.ApiRespon
{
    public class APIResponse
    {
        public APIResponse()
        {
            ErrorMessages = new List<string>();
        }
        public HttpStatusCode StatusCode { set; get; }
        public bool IsSuccess { set; get; } = true;

        public List<string> ErrorMessages { set; get; }

        public object Result { set; get; }
    }
}
