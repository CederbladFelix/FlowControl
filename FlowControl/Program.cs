namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                PrintMainMenu();

                int userInput = Utilities.GetValidatedInteger("Välj ett alternativ (0-4):");

                switch (userInput)
                {
                    case CaseHelper.TurnOffProgram:
                        running = TurnOffProgram();
                        break;

                    case CaseHelper.GetCostByAge:
                        GetCostByAge();
                        break;

                    case CaseHelper.GetTotalCostForGroup:
                        GetTotalCostForGroup();
                        break;

                    case CaseHelper.WriteTenTimes:
                        WriteTenTimes();
                        break;

                    case CaseHelper.ThirdWordInSentence:
                        GetThirdWordInASentence();
                        break;

                    default:
                        Console.WriteLine("Felaktig input. Vänligen välj mellan 0 och 4.");
                        break;
                }
            }
        }


        private static void PrintMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Välkommen till Huvudmenyn. Navigera denna genom att skriva in rätt siffra:");
            Console.WriteLine("0. Avsluta programmet");
            Console.WriteLine("1. Vilket pris behöver personen betala");
            Console.WriteLine("2. Räkna ut priset för ett helt sällskap");
            Console.WriteLine("3. Upprepa det som skrivs in tio gånger");
            Console.WriteLine("4. Skriva ut det tredje ordet i en mening med minst tre ord");
        }

        private static bool TurnOffProgram()
        {
            Console.WriteLine("Nu stängs programmet.");
            return false;
        }

        private static void GetCostByAge()
        {
            int age = Utilities.GetValidatedInteger("Ange en ålder i siffror:");

            string name = Pricing.GetNameByAge(age);
            int price = Pricing.GetPriceByAge(age);


            Console.WriteLine($"{name}pris: {price}kr");

        }

        private static void GetTotalCostForGroup()
        {
            int numberOfMovieVisitors = Utilities.GetValidatedInteger("Ange hur många som ska gå på bio:");
            int finalCost = 0;

            for (int i = 0; i < numberOfMovieVisitors; i++)
            {
                int visitorAge = Utilities.GetValidatedInteger($"Hur gammal är person nr {i + 1}?");
                finalCost += Pricing.GetPriceByAge(visitorAge);

            }

            Console.WriteLine($"Det är {numberOfMovieVisitors} som ska gå på bio.");
            Console.WriteLine($"Det kommer att kosta: {finalCost}kr");
        }
        private static void WriteTenTimes()
        {
            string arbitraryText = Utilities.GetValidatedString("Ange en godtycklig text:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arbitraryText);
            }
        }

        private static void GetThirdWordInASentence()
        {
            string threeWordSentence = Utilities.GetValidatedString("Ange en mening med minst tre ord:");
            string[] threeWordSentenceSplit = threeWordSentence.Split([' '], StringSplitOptions.RemoveEmptyEntries);


            if (threeWordSentenceSplit.Length >= 3)
            {
                Console.WriteLine("Det tredje ordet är: " + threeWordSentenceSplit[2]);
            }
            else
            {
                Console.WriteLine("Meningen innehöll inte minst tre ord.");
            }
        }

    }
}
