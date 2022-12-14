using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using PKRTravels.Models;

namespace PKRTravels
{
    public class ContextDB:DbContext
    {
        public ContextDB()
        {

        }
        public ContextDB(DbContextOptions<ContextDB>options) : base(options)
        {
            
        }
        public DbSet<TravelsDB> TravelsDBs { get; set; }
       
    }
}
