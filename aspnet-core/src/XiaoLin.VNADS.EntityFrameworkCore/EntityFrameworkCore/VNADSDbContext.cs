using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using XiaoLin.VNADS.Authorization.Roles;
using XiaoLin.VNADS.Authorization.Users;
using XiaoLin.VNADS.MultiTenancy;

namespace XiaoLin.VNADS.EntityFrameworkCore
{
    public class VNADSDbContext : AbpZeroDbContext<Tenant, Role, User, VNADSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public VNADSDbContext(DbContextOptions<VNADSDbContext> options)
            : base(options)
        {
        }
    }
}
