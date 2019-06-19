using Abp.Application.Services;
using Abp.Application.Services.Dto;
using XiaoLin.VNADS.MultiTenancy.Dto;

namespace XiaoLin.VNADS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

