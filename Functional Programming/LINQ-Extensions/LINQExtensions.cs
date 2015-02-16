namespace LINQ_Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class LINQExtensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = from item in collection
                         where predicate(item) == false
                         select item;
            return result;
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            List<T> innerCollection = new List<T>();

            for (int i = 0; i < count; i++)
            {
                foreach (var item in collection)
                {
                    innerCollection.Add(item);
                }
            }

            return innerCollection;
        }

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            List<string> innerCollection = new List<string>();

            foreach (var item in collection)
            {
                foreach (var suffix in suffixes)
                {
                    if (item.EndsWith(suffix))
                    {
                        innerCollection.Add(item);
                        break;
                    }
                }
            }

            return innerCollection;
        }
    }
}
