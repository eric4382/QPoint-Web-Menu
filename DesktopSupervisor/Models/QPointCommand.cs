namespace DesktopSupervisor.Models
{
    public class QPointCommand
    {
        public string Type { get; set; }
        public string Source { get; set; }
        public string Action { get; set; }
        public long Timestamp { get; set; }
        public object Payload { get; set; }
    }
}
