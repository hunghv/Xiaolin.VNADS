using Abp.MultiTenancy;
using XiaoLin.VNADS.Authorization.Users;

namespace XiaoLin.VNADS.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
