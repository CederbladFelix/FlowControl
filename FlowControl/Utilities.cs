using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal static class Utilities
    {
        public static int GetValidatedInteger(string prompt)
        {
            int validationOutput = 0;
            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(userInput, out validationOutput))
                {
                    return validationOutput;
                }
                else
                {
                    Console.WriteLine("Du skrev in i fel format, testa igen");
                }
            }
        }
        public static string GetValidatedString(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string userInput = Console.ReadLine() ?? string.Empty;

                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Du måste skriva någonting, testa igen");
                }
            }
        }
    }
}
