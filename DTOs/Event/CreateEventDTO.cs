using System.ComponentModel.DataAnnotations;

namespace Piglet_Domain_Models.DTOs.Event
{
    public class CreateEventDTO
    {
        [Required, MaxLength(33)]
        public required string Name { get; set; }

        [Required]
        public required string CreatorDiscordUsername { get; set; }

        [MaxLength(12)]
        public string? Author { get; set; }

        [MaxLength(150)]
        public string? Description { get; set; }

        [Required]
        public required DateTime StartTime { get; set; }

        [Required]
        public required DateTime EndTime { get; set; }
    }
}
