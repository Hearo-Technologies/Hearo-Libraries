using System;
using System.Collections.Generic;

namespace Hearo_Libraries.Models
{
    public class ApprovedSensorDataAttribute
    {
        public string AttributeString { get; set; }
        public Guid ApprovedSensorId { get; set; }
        public ApprovedSensor ApprovedSensor { get; set; }
        public List<DataAttributeValue> Values { get; set; }
        public string Description { get; set; }
        public string ValueType { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public double ValueStep { get; set; }

    }
}