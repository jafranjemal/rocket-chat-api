using Microsoft.EntityFrameworkCore;
using roket_chat_api.Entities;

namespace roket_chat_api.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }



    }
}
