using My_VillaUtility;
using static My_VillaUtility.SD;

namespace My_VillaWeb.Models.ApiHttp
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }

        public string Token { set; get; }

}
}
