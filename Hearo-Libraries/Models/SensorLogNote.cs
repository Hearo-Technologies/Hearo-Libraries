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
        
        public Boolean InitialNote { get; set; } = false;
        
        // if was InitialNote, will save time elapsed between sensor log and note in minutes.
        public Int32? ReactionTime { get; set; }

    }
}