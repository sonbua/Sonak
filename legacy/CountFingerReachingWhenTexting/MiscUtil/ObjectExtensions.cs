using System.Collections.Generic;
using System.Linq;

namespace MiscUtil
{
    public static class ObjectExtensions
    {
        public static bool IsIn<T>(this T element, IEnumerable<T> collection)
        {
            return collection.Contains(element);
        }

        public static bool IsNotIn<T>(this T element, IEnumerable<T> collection)
        {
            return !collection.Contains(element);
        }
    }
}