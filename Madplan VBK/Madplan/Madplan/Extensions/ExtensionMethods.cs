using System;
using System.Linq;
using System.Reflection;

namespace Madplan.Extensions
{
    public static class ExtensionMethods
    {
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
    }
}
