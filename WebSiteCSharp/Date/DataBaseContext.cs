using Microsoft.EntityFrameworkCore;
using WebSiteCSharp.Models;

namespace WebSiteCSharp.Date
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options){}

        public DbSet<ContactModel> Contacts
        { get; set; }
    }
}
