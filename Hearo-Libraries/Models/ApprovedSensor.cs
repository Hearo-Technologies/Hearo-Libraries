using System;
using System.Collections.Generic;

namespace Hearo_Libraries.Models
{
    public class ApprovedSensor
    {
        public Guid ApprovedSensorId { get; set; }
        public List<ApprovedSensorDataAttribute> DataAttributes { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string ProductUrl { get; set; }
        public string PurchaseUrl { get; set; }
        public string Image { get; set; }
        public string ZWaveManufacturerId { get; set; }
        public string ZWaveProductId { get; set; }
        public string NewSensorDefaultTemplate { get; set; }
        public string Protocol { get; set; }
        public string InstallationNotes { get; set; }

        public string ProductName
        {
            get
            {
                return Brand + " " + Name;
            }
        }
    }
}