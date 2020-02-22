using System;
using System.Collections.Generic;
using System.Linq;

namespace Tobe.Core
{
    public static class EditorGuiHelpers
    {
        public static void PrintArray<TValue>(IEnumerable<TValue> array, Action<int, TValue> printRow)
        {
            var values = array as TValue[] ?? array.ToArray();

            for (var index = 0; index < values.Count(); index++)
            {
                var value = values.ElementAt(index);

                printRow(index, value);
            }
        }
    }
}