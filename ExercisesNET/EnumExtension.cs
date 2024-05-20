using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesNET
{
    public static class EnumExtension
    {
        public static T ToEnum<T>(this string val, T defVal, bool ignoreCase) 
        {
            val = val.Trim();

            if (string.IsNullOrEmpty(val))
            {
                return defVal;
            }

            Type type = typeof(T);
            if (Nullable.GetUnderlyingType(type) != null)
            {
                type = Nullable.GetUnderlyingType(type);
            }

            if (!Enum.IsDefined(type, val))
            {
                return defVal;
            }

            return (T)Enum.Parse(type, val, ignoreCase);
        }
    }
}
