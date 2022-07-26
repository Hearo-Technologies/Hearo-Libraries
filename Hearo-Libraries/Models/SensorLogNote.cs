using System;
using System.Collections.Generic;

namespace Hearo_Libraries.Models
{
    public class SensorLogNote
    {
        public IList<IndividualDisplayInfo> Individuals { get; set; }
        
        public IList<string> Tags { get; set; }
        
        public string Note { get; set; }
        
        public UserDisplayInfo User { get; set; }

        public Boolean Dismissed { get; set; } = false;
        
        public DateTime Date { get; set; }
    }
}