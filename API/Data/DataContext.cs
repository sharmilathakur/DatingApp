using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
           
        }
         public DbSet<AppUser> Users { get; set; } 
            //appuser is a class name and Users is a TableName that will be
            //generate in db
    }
}