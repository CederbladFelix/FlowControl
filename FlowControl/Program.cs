using System.Reflection.Metadata.Ecma335;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen till Huvudmenyn. Navigera denna genom att skriva in" +
                "rätt siffra till rätt funktion");

            bool running = true;

            while (running)
            {
                int userInput = 0;
                switch (userInput)
                {
                    case 0:
                        Console.WriteLine("Nu stängs programmet");
                        break;
                    default:
                        Console.WriteLine("Felaktig input");
                        break;
                }

            }
        }
    }
}
