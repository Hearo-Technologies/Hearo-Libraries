using System;
using Hearo_Libraries.Models;

namespace Hearo_Libraries
{
    public class SensorLibrary
    {
        public static void HelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
        private Sensor DoorSensorDefaults(Guid id)
        {
            return new Sensor {
                SensorTypeId = id,
                Categories = "",
                QueueTime = 100,
                QueueTimeFormat = "ms",
                Type = "door"
            };
        }

        private Sensor MotionDetectorDefaults(Guid id)
        {
            return new Sensor
            {
                SensorTypeId = id,
                Categories = "",
                QueueTime = 0,
                QueueTimeFormat = "ms",
                Type = "motion"
            };
        }

        private Sensor AlarmDetectorDefaults(Guid id) {
            return new Sensor
            {
                SensorTypeId = id,
                Categories = "alarm",
                QueueTime = 0,
                QueueTimeFormat = "ms",
                Type = "alarm"
            };
        }

        private Sensor ButtonDefaults(Guid id)
        {
            return new Sensor
            {
                SensorTypeId = id,
                Categories = "",
                QueueTime = 100,
                QueueTimeFormat = "ms",
                Type = "button"
            };
        }

        private Sensor LightbulbDefaults(Guid id)
        {
            return new Sensor
            {
                SensorTypeId = id,
                Categories = "light",
                QueueTime = 0,
                QueueTimeFormat = "ms",
                Type = "light"
            };
        }

        private Sensor PowerswitchDefaults(Guid id)
        {
            return new Sensor
            {
                SensorTypeId = id,
                Categories = "power",
                QueueTime = 0,
                QueueTimeFormat = "ms",
                Type = "powerSwitch"
            };
        }

        private Sensor SirenDefaults(Guid id)
        {
            return new Sensor
            {
                SensorTypeId = id,
                Categories = "alarm",
                QueueTime = 0,
                QueueTimeFormat = "ms",
                Type = "siren"
            };
        }

        private Sensor DoorLockDefaults(Guid id)
        {
            return new Sensor {
                SensorTypeId = id,
                Categories = "favorite, egress",
                QueueTime = 200,
                QueueTimeFormat = "ms",
                Type = "door_lock"
            };
        }
    }
}