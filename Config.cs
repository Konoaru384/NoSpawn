using Exiled.API.Interfaces;

namespace NoSpawn
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public int DelayHours { get; set; } = 0;
        public int DelayMinutes { get; set; } = 40;
        public int DelaySeconds { get; set; } = 0;
    }
}
