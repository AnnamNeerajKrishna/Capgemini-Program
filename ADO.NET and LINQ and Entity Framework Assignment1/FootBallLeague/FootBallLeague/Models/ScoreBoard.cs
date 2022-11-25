using System.ComponentModel.DataAnnotations;

namespace FootBallLeague.Models
{
    public class ScoreBoard
    {
        [Key]
        public int MatchId { get; set; }
        [Required(ErrorMessage ="Need To Enter the Details")]
        public string TeamName1 { get; set; }
        [Required(ErrorMessage ="Need To Enter The Details")]
        public string TeamName2 { get; set;}
        [Required(ErrorMessage ="Need To Enter The Details")]
        public string Status { get; set; }
        public string WinningTeams { get; set; }
        [Required(ErrorMessage ="Need To Enter The Details")]
        public int Points { get; set;}

    }
}
