using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piglet_Domain_Models.DTOs.Event
{
    public class CreateEventDTO
    {
        [Required, MaxLength(33)]
        public required string Name { get; set; }

        [Required]
        public required string CreatorDiscordUsername { get; set; }

        [MaxLength(12)]
        public string? Description { get; set; }

        [Required]
        public required DateTime StartTime { get; set; }

        [Required]
        public required DateTime EndTime { get; set; }
    }
}
