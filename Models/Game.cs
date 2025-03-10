using System.ComponentModel.DataAnnotations;

namespace Demo_Project_Game_Events.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }    // 5

        [Required(ErrorMessage = "Game name is required"), MaxLength(30)]
        public string GameName { get; set; }

        [Required(ErrorMessage = "Game type is required"), MaxLength(20)]
        public string GameType { get; set; }
        public virtual ICollection<GameEvent> GameEvents { get; set; }  // Event Objs 1, 2
    }
}
