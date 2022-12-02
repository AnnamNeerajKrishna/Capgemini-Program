using Microsoft.EntityFrameworkCore;
using PKRTravels.Models;

namespace PKRTravels
{
    public class ADDContextDB:DbContext
    {
        public ADDContextDB():base()
        {

        }
        public ADDContextDB(DbContextOptions<ADDContextDB> options) : base(options)
        {

        }
        public DbSet<TravelsDB> TravelsDB { get; set; }
    }
}
