using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Upd8.Infra.Data.Context
{
    public class SqlContextFactory : IDesignTimeDbContextFactory<SqlContext>
    {
        public SqlContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Database=Updoito;Trusted_Connection=True;Encrypt=False";
            var optionBuilder = new DbContextOptionsBuilder<SqlContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new SqlContext(optionBuilder.Options);
        }
    }
}
