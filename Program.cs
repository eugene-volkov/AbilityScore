using System;

namespace AbilityScore
{
    class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            
            while (true)
            {
                calculator.Roll = ReadInt(calculator.Roll, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();

                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other ket to continue");
                
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == 'Q' || keyChar == 'q')
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Writes a promt and reads an int value from the console
        /// </summary>
        /// <param name="lastUsedValue">The default value</param>
        /// <param name="promt">Promt to print to the console</param>
        /// <returns>The int value read, or the default value if unable to parse</returns>
        private static int ReadInt(int lastUsedValue, string promt)
        {
            Console.WriteLine(promt + " [" + lastUsedValue + "]: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine("  using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine("  using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }

        private static double ReadDouble(double lastUsedValue, string promt)
        {
            Console.WriteLine(promt + " [" + lastUsedValue + "]: ");
            string line = Console.ReadLine();
            if (double.TryParse(line, out double value))
            {
                Console.WriteLine("  using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine("  using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}











