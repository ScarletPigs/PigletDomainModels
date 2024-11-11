using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piglet_Domain_Models.DTOs.Event
{
    public class EditEventDTO
    {
        [Required]
        public required int Id { get; set; }

        [MaxLength(33)]
        public string? Name { get; set; }

        public string? CreatorDiscordUsername { get; set; }

        [MaxLength(12)]
        public string? Author { get; set; }

        [MaxLength(150)]
        public string? Description { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }
    }
}
