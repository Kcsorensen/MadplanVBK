using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Madplan.Extensions
{
    public static class ExtensionMethods
    {
        #region Description Helper
        public static T GetAttributeOfType<T>(this Enum enumVal) where T : Attribute
        {
            var typeInfo = enumVal.GetType().GetTypeInfo();
            var v = typeInfo.DeclaredMembers.First(x => x.Name == enumVal.ToString());

            return v.GetCustomAttribute<T>();
        }

        public static string GetDescription(this Enum enumVal)
        {
            var attr = GetAttributeOfType<MyDescriptionAttribute>(enumVal);

            return attr != null ? attr.Text : string.Empty;
        }

        #endregion

        #region String to Double Converter

        public static double ConvertToDouble(this string stringVal)
        {
            var doubleVal = double.NaN;

            if (!string.IsNullOrWhiteSpace(stringVal))
            {
                doubleVal = Convert.ToDouble(stringVal, new CultureInfo("da-DK"));
            }

            return doubleVal;
        }

        #endregion


        public static void CopyFrom<TTo, TFrom>(this TTo target, TFrom source) where TTo : class
        {
            if (target == null)
                throw new ArgumentNullException();
            // Preserve object graph structure and handle polymorphic fields.
            var settings = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.All, ReferenceLoopHandling = ReferenceLoopHandling.Serialize, TypeNameHandling = TypeNameHandling.Auto };
            var json = JsonConvert.SerializeObject(source, settings);
            JsonConvert.PopulateObject(json, target, settings);
        }
    }

  
}
