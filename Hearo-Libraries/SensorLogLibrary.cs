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
        public static ExpandoObject ConvertCategoriesToTags(IList<string>? categories)
        {
            var tags = new ExpandoObject();

            if (categories != null && categories.Count > 0)
            {
                foreach (var cat in categories)
                {
                    AddProperty(tags, cat, true);
                }
            }

            return tags;
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