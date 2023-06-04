using System;
using System.Text;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));
            int tot = 1;
            for (int i = 2; i <= n; i++)
                tot *= i;
            return tot;
        }

        public static string FormatSeparators(params string[] items)
        {
            if (items == null || items.Length == 0)
                return "";
            int limit = items.Length - 1;
            int commaLimit = limit - 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < limit; i++)
            {
                sb.Append(items[i]);
                if (i < commaLimit)
                    sb.Append(", ");
                else
                    sb.Append(" and ");
            }
            sb.Append(items[limit]);
            return sb.ToString();
        }
    }
}