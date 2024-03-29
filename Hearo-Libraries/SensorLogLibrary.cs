#nullable enable
using System.Collections.Generic;
using System.Dynamic;
using System.Text.RegularExpressions;

namespace Hearo_Libraries
{
    public class SensorLogLibrary
    {
        public static ExpandoObject ConvertCategoriesToTags(IList<string>? categories)
        {
            var tags = new ExpandoObject();

            if (categories != null && categories.Count > 0)
            {
                foreach (var cat in categories)
                {
                    if (cat != "skip_visible_timeline")
                    {
                        
                    }
                    var normalizedCat = Regex.Replace(cat, "[^A-Za-z0-9 -_]", "");

                    AddProperty(tags, normalizedCat, true);
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