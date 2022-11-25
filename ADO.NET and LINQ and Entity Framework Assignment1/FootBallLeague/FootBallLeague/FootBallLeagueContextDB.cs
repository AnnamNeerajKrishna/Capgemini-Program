using FootBallLeague.Models;
using Microsoft.EntityFrameworkCore;

namespace FootBallLeague
{
    public class FootBallLeagueContextDB:DbContext
    {
        public FootBallLeagueContextDB():base()
        {
           
        }
        public FootBallLeagueContextDB(DbContextOptions<FootBallLeagueContextDB> options) : base(options)
        {

        }
        public DbSet<ScoreBoard> ScoreBoards { get; set; }  

    }
}
