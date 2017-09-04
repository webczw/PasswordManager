using Password.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<DataType> DataTypes { get; set; }
        
        public DbSet<Content> Contents { get; set; }

        public DbSet<UserField> UserFields { get; set; }

        public DbSet<UserFieldValue> UserFieldValues { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<Field> Fields { get; set; }

        public DbSet<Log> Logs { get; set; }
    }
}
