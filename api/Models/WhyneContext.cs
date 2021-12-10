using System;
using Microsoft.EntityFrameworkCore;

namespace Api.Models
{
    public class WhyneContext : DbContext
    {
        // DbSets
        public DbSet<Account> Accounts { get; set; }

        // Configuration
        private string _dbPath = @"Server=localhost;Port=64131;Database=Whyne;Uid=WhyneAdmin;Pwd=123456";
        public MariaDbServerVersion DbServerVersion { get; private set; }

        public WhyneContext()
        {
            DbServerVersion = new MariaDbServerVersion(new Version(10,6,5));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(_dbPath, DbServerVersion);

    }
}
