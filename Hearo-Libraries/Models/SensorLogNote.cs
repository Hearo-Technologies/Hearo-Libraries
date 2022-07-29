using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Hearo_Libraries.Models
{
    public class SensorLogNote
    {
        [Newtonsoft.Json.JsonProperty(PropertyName="id")]
        public string Id { get; set; }
        
        public SensorLogDisplayInfo SensorLog { get; set; }

        public LocationDisplayInfo Location { get; set; }
        
        public IList<IndividualDisplayInfo> Individuals { get; set; }
        
        public ExpandoObject Tags { get; set; }
        
        public string Note { get; set; }
        
        public UserDisplayInfo User { get; set; }

        public Boolean Dismissed { get; set; } = false;
        
        public DateTime Date { get; set; }
    }
}