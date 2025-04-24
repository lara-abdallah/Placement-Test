using System;
using System.Collections.Generic;

namespace Placement_Test
{
    class LuckyTicketNumber
    {
        public static long LuckyTicket(int n)
        {
            if (n % 2 != 0 || n <= 0)
                return 0;

            int half = n / 2;
            int max = 9 * half;

            long[] count = new long[max + 1];
            count[0] = 1;

            for (int position = 0; position < half; position++)
            {
                long[] nextdigit = new long[max + 1];
                for (int sum = 0; sum <= max; sum++)
                {
                    for (int digit = 0; digit <= 9; digit++)
                    {
                        if (sum + digit <= max)
                        {
                            nextdigit[sum + digit] += count[sum];
                        }
                    }
                }
                count = nextdigit;
            }

            long total = 0;
            for (int i = 0; i <= max; i++)
            {
                total += count[i] * count[i];
            }
            return total;
        }
        public static int SumDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int last = number % 10;
                sum += last;
                number /= 10;
            }
            return sum;
        }
    }
}
