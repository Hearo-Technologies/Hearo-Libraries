using System;
using System.Collections.Generic;
using System.Dynamic;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Dynamic;
using Hearo_Libraries.Models;

namespace Hearo_Libraries
{
    public class SensorLogLibrary
    {
        public static void HelloWorld()
        {
            Console.WriteLine("Hello world!");
        }

        public SensorLog FormatSensorLog(SensorLog sensorLog)
        {
            sensorLog.Tags = ConvertCategoriesToTags(sensorLog.Categories);
            sensorLog.mm = sensorLog.Date.ToString("MM");
            sensorLog.dd = sensorLog.Date.ToString("dd");
            sensorLog.yyyy = sensorLog.Date.ToString("yyyy");
            sensorLog.yyyymmdd = sensorLog.Date.ToString("yyyyMMdd");
            
            return sensorLog;
        }
        public ExpandoObject ConvertCategoriesToTags(IList<string>? categories)
        {
            var Tags = new ExpandoObject();

            if (categories != null && categories.Count > 0)
            {
                foreach (var cat in categories)
                {
                    AddProperty(Tags, cat, true);
                }
            }

            return Tags;
        }
        public static void AddProperty(ExpandoObject expando, string propertyName, object propertyValue)
        {
            // ExpandoObject supports IDictionary so we can extend it like this
            var expandoDict = expando as IDictionary<string, object>;
            if (expandoDict.ContainsKey(propertyName))
                expandoDict[propertyName] = propertyValue;
            else
                expandoDict.Add(propertyName, propertyValue);
        }
    }
}