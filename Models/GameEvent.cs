using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Project_Game_Events.Models
{
    public class GameEvent
    {
        [Key]
        public int EventId { get; set; }           // 1  , 2
        public DateTime EventDate{ get; set; }     // 07-03-2025,10-03-2025


        [ForeignKey("Game")]
        public int GameId { get; set; }            // 5,  5
        public virtual Game Game { get; set; }   // reference navigation property

       
        [ForeignKey("Player")]
        public int PlayerId { get; set; }         // 10,  10
        public virtual Player Player { get; set; }
        public string Outcomes { get; set; }        // Player thrown Javelin at 86.75 M
                                                    // Player thrown Javelin at 88 M
    }
}
