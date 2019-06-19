using Microsoft.AspNetCore.Antiforgery;
using XiaoLin.VNADS.Controllers;

namespace XiaoLin.VNADS.Web.Host.Controllers
{
    public class AntiForgeryController : VNADSControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
