using System;
using System.Collections.Generic;

namespace Hearo_Libraries.Models
{
    public class Sensor
    {
        public Guid SensorId { get; set; }
        
        public ApprovedSensor SensorType { get; set; }
        public Guid SensorTypeId { get; set; }
        
        // public Individual Individual { get; set; }
        public Guid? IndividualId { get; set; }

        // public Location Location { get; set; }
        public Guid? LocationId { get; set; }

        public List<SensorValue> SensorValues { get; set; }

        public string LocalId { get; set; }
        public string Placement { get; set; }
        public string Zone { get; set; }
        public string Type { get; set; }
        public string Categories { get; set; }
        public string Icon { get; set; }
        public int? QueueTime { get; set; }
        public string QueueTimeFormat { get; set; }
        public List<SensorMeta> Meta { get; set; }



        public string Id
        {
            get { return LocalId; }
            set { LocalId = value; }
        }

        public string ProductName
        {
            get
            {
                if (SensorType != null)
                {
                    return SensorType.Brand + " " + SensorType.Name;   
                }

                return "";
            }
        }
    }
}