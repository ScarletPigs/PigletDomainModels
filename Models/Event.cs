namespace Piglet_Domain_Models.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string CreatorDiscordUsername { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        




        public EventType EventType { get; set; }
        public ModList ModList { get; set; }


    }
}
