using System;

namespace Hearo_Libraries.Models
{
    public class SensorValue
    {
        public string ValueType { get; set; }
        public Sensor Sensor { get; set; }
        public Guid SensorId { get; set; }
        public string StringValue { get; set; }
        public int IntValue { get; set; }
        public double DecimalValue { get; set; }
        public string PreviousStringValue { get; set; }
        public int PreviousIntValue { get; set; }
        public double PreviousDecimalValue { get; set; }
        public DateTime ValueDate { get; set; }
        public DateTime LatestDate { get; set; }

    }
}