using System.Data.Entity;

namespace Schoolboy.Data
{
   public class ApplicationContext : DbContext
   {     
        public ApplicationContext() : base("ApplicationContext")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Schoolboy> Schoolboys { get; set; }
    }
}
