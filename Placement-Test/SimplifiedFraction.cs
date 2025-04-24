using System;

namespace Placement_Test
{
    class SimplifiedFraction
    {
        public static string Simplify(string fraction)
        {
            try
            {
                string[] allParts = fraction.Split("/");

                int numerator = int.Parse(allParts[0]);
                int denominator = int.Parse(allParts[1]);

                if (denominator == 0)
                {
                    return "Denominator cannot be 0. Please try again!";
                }

                int gcd = GCD(numerator, denominator);

                numerator = numerator / gcd;
                denominator = denominator / gcd;

                if (denominator == 1)
                {
                    return numerator.ToString();
                }
                return numerator + "/" + denominator;
            }
            catch (Exception)
            {
                return "Invalid format. Please enter a valid fraction!";
            }
            
        }

        static int GCD(int num1, int num2)
        {
            int Remainder;

            while (num2 != 0)
            {
                Remainder = num1 % num2;
                num1 = num2;
                num2 = Remainder;
            }

            return num1;
        }
    }
}
