using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using XiaoLin.VNADS.Controllers;

namespace XiaoLin.VNADS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : VNADSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
