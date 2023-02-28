﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanotek.Helpers
{
    /// <summary>
    /// Helper methods for <seealso cref="IList{T}"/> instances
    /// </summary>
    public static class ListHelper
    {
        private readonly static Random _rng = new Random();

        /// <summary>
        /// Shuffles all the data that is in the given <paramref name="list"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">A list of type T/>/></param>
        public static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = _rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
