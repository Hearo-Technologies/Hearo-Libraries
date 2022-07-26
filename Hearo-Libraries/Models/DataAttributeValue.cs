using System;

namespace Hearo_Libraries.Models
{
    public class DataAttributeValue
    {
        public string AttributeString { get; set; }
        public ApprovedSensorDataAttribute DataAttribute { get; set; }
        public Guid ApprovedSensorId { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
    }
}