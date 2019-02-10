using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExercice
{
    public static class StringExtension
    {
        /// <summary>
        /// El total de palabras
        /// </summary>
        /// <param name="hello"></param>
        /// <param name="value"></param>
        /// <returns>Calcula el total de palabras y asi sabe si es mas grande o mas pequeña</returns>
        public static bool TotalWordsGreaterThan(this string hello, int value) => hello.Length > value;
    }
}
