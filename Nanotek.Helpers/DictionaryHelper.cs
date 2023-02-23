using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanotek.Helpers
{
    public static class DictionaryHelper
    {
        public static void AddOrIncrement<T>(Dictionary<T, int> dict, T key, int by = 1) where T : notnull
        {
            if (dict.ContainsKey(key))
                dict[key] += by;
            else
                dict.Add(key, by);
        }

        public static void AddOrIncrement<T>(Dictionary<T, double> dict, T key, double by = 1) where T : notnull
        {
            if (dict.ContainsKey(key))
                dict[key] += by;
            else
                dict.Add(key, by);
        }

        public static void AddOrIncrement<T>(Dictionary<T, long> dict, T key, long by = 1) where T : notnull
        {
            if (dict.ContainsKey(key))
                dict[key] += by;
            else
                dict.Add(key, by);
        }
    }
}
