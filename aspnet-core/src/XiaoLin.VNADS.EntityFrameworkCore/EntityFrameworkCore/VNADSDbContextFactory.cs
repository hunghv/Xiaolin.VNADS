using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using XiaoLin.VNADS.Configuration;
using XiaoLin.VNADS.Web;

namespace XiaoLin.VNADS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class VNADSDbContextFactory : IDesignTimeDbContextFactory<VNADSDbContext>
    {
        public VNADSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VNADSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            VNADSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(VNADSConsts.ConnectionStringName));

            return new VNADSDbContext(builder.Options);
        }
    }
}
