using System;

namespace Hearo_Libraries.Models
{
    public class IndividualDisplayInfo {
        public Guid Id { get; set;  }
        public string Name { get; set; }
        public string Image { get; set; }
    }
    public class UserDisplayInfo {
        public Guid Id { get; set;  }
        public string Name { get; set; }
    }

    public class LocationDisplayInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class SensorLogDisplayInfo
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}