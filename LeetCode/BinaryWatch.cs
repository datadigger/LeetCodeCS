namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class BinaryWatch
    {
        public IList<string> ReadBinaryWatch(int num)
        {
            var results = new List<string>();

            var bits = new int[10];

            if (num == 0)
            {
                results.Add("0:00");
            }
            else
            {
                var resultSet = new HashSet<string>();
                for (var i = 0; i < 10; ++i)
                {
                    bits[i] = 1;
                    doReadBinaryWatch(num - 1, bits, resultSet);
                    bits[i] = 0;
                }

                foreach (var reading in resultSet)
                {
                    results.Add(reading);
                }
            }

            return results;
        }

        private void doReadBinaryWatch(int sum, int[] bits, HashSet<string> results)
        {
            if (sum == 0)
            {
                var hour = toHour(bits);
                var min = toMin(bits);

                if (hour < 12 && min < 60)
                {
                    results.Add($"{hour}:{min:D2}");
                }
                return;
            }

            for (int i = 0; i < 10; ++i)
            {
                if (bits[i] == 1)
                {
                    continue;
                }

                bits[i] = 1;
                doReadBinaryWatch(sum - 1, bits, results);
                bits[i] = 0;
            }
        }

        private static int toMin(int[] bits)
        {
            var min = 0;
            for (var i = 4; i < 10; ++i)
            {
                min *= 2;
                min += bits[i];
            }
            return min;
        }

        private static int toHour(int[] bits)
        {
            var hour = 0;
            for (var i = 0; i < 4; ++i)
            {
                hour *= 2;
                hour += bits[i];
            }
            return hour;
        }
    }
}