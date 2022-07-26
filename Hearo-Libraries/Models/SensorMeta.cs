using System;

namespace Hearo_Libraries.Models
{
    public class SensorMeta
    {
        public Guid Id { get; set; }
        public Guid SensorId { get; set; }
        public Sensor Sensor { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public bool IsUnique { get; set; }
    }

    public class UserCode
    {
        public int Code { get; set; }
        public string UserName { get; set; }
        public Boolean Provider { get; set; }
    }
}