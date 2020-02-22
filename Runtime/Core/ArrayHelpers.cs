namespace Tobe.Core
{
    public static class ArrayHelpers
    {
        public static TValue[] RemoveAt<TValue>(TValue[] array, int index)
        {
            var result = new TValue[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == index) continue;
                if (i < index)
                {
                    result[i] = array[i];
                }
                else
                {
                    result[i - 1] = array[i];
                }
            }

            return result;
        }
    }
}