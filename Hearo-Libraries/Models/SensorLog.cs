using System;
using System.Collections.Generic;
using System.Dynamic;
using Hearo_Libraries.Models;

namespace Hearo_Libraries.Models
{
    public class SensorLog
    {
        public string Id { get; set; }
        public string SensorLogId { get; set; }
        public string SensorId { get; set; }
        public Guid? SensorGuid { get; set; }
        public string IndividualId { get; set; }
        public string LocationId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? CompanyId { get; set;  }
        public string ProductName { get; set; }
        public string Placement { get; set; }
        public string Type { get; set; }
        public IList<string> Categories { get; set; }
        public int Value { get; set; }
        public double DecimalValue { get; set; }
        public string Description { get; set; }
        public string AdvancedValue { get; set; }
        
        public List<SensorLogNote>? Notes { get; set; }
        public DateTime Date { get; set; }
        public string Icon { get; set; }
        public ExpandoObject Tags { get; set; }
        public string mm { get; set; }
        public string dd { get; set; }
        public string yyyy { get; set; }
        public string yyyymmdd { get; set; }
    }
}