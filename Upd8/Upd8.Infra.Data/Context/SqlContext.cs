using Microsoft.EntityFrameworkCore;
using Upd8.Core.Domain.Entities;
using Upd8.Infra.Data.Mapping;

namespace Upd8.Infra.Data.Context
{
    public class SqlContext: DbContext
    {

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly);
        }
    }
}
