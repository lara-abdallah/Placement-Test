using System;

namespace Placement_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // SimplifiedFraction testing examples
            Console.WriteLine(SimplifiedFraction.Simplify("4/6"));
            Console.WriteLine(SimplifiedFraction.Simplify("10/11"));
            Console.WriteLine(SimplifiedFraction.Simplify("100/400"));
            Console.WriteLine(SimplifiedFraction.Simplify("8/4"));
            Console.WriteLine(SimplifiedFraction.Simplify("4/0"));
            Console.WriteLine(SimplifiedFraction.Simplify("85"));

            // MaximumOccurrence testing examples
            Console.WriteLine(MaximumOccurrence.MaxOccur("Computer Science"));
            Console.WriteLine(MaximumOccurrence.MaxOccur("Edabit"));
            Console.WriteLine(MaximumOccurrence.MaxOccur("system admin"));
            Console.WriteLine(MaximumOccurrence.MaxOccur("The quick brown fox jumps over the lazy dog"));
            Console.WriteLine(MaximumOccurrence.MaxOccur(""));

            // LuckyTicketNumber testing examples
            Console.WriteLine(LuckyTicketNumber.LuckyTicket(0));
            Console.WriteLine(LuckyTicketNumber.LuckyTicket(2));
            Console.WriteLine(LuckyTicketNumber.LuckyTicket(4));
            Console.WriteLine(LuckyTicketNumber.LuckyTicket(12));
        }

    }
}

