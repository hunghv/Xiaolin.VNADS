using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace XiaoLin.VNADS.EntityFrameworkCore
{
    public static class VNADSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VNADSDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VNADSDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
