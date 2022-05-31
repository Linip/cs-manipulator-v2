using System.Data.Entity;
using Manipulator.Shared.Models;
using SQLite.CodeFirst;

namespace Manipulator.Shared.Infrastructure
{
    public class SqliteContext : DbContext
    {
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<ControlObject> Manipulators { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<SqliteContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }
    }
}