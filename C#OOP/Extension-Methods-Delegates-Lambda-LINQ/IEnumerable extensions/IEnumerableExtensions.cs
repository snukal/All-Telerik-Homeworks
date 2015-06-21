
namespace IEnumerable_extensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public static class IEnumerableExtensions<T>
    {
        public static void Sum(this IEnumerable<T> target)
        {
            var sum = 0m;
            foreach (var item in target)
            {
                sum += Convert.ToDecimal(item);
            }
        }
        public static void Product(this IEnumerable<T> target)
        {
            var sum = 1m;
            foreach (var item in target)
            {
                sum *= Convert.ToDecimal(item);
            }
        }

        public static void Average(this IEnumerable<T> target) 
        {
            var AverageSum = new List<decimal>();
            var sum = 0m;
            foreach (var item in target)
            {
                AverageSum.Add(Convert.ToDecimal(item));
            }
            foreach (var item in AverageSum)
            {
                sum += item;
            }
            var averageSum = sum / AverageSum.Count;
        }

        public static T Min<T>(this IEnumerable<T> target) 
        {
            return target.Min();
        }
        public static T Max<T>(this IEnumerable<T> target)
        {
            return target.Max();
        }


    }
}
