using System.ComponentModel.DataAnnotations;

namespace Demo_Project_Game_Events.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required(ErrorMessage ="Player name is required"), MaxLength(40)]
        public string PlayerName { get; set; }

        [Required(ErrorMessage = "Country is required"), MaxLength(30)]
        public string Country { set; get; }

        public int Age { set; get;  }

        public virtual ICollection<GameEvent> GameEvents { get; set; }
    }
}
