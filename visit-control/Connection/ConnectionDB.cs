using System.Data.Entity;
using visit_control.Models;
using visit_control.Properties;

namespace visit_control.Connection
{
    public class ConnectionDB: DbContext
    {
        public ConnectionDB(): base(Settings.Default.Connection)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Visitors> Visitors { get; set; }
        public virtual DbSet<Visitors_Department> Visitors_Department { get; set; }
    }
}
