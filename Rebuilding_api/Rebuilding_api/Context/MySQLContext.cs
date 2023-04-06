using Microsoft.EntityFrameworkCore;
using Rebuilding_api.Models;

namespace Rebuilding_api.Context {
    public class MySQLContext : DbContext {

        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Billing> Billings { get; set; }

    }
}
