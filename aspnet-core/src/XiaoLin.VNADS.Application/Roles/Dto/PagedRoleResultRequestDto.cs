using Abp.Application.Services.Dto;

namespace XiaoLin.VNADS.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

