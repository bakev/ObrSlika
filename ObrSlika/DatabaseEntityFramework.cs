using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrSlika
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext():
            base ("vlatko")
        { }
        public DbSet<Login> Logins { get; set; }
    }

    public class Login
    {
        [Key]
        public String Username { get; set; }
        public String Password { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String Email { get; set; }
    }
}
