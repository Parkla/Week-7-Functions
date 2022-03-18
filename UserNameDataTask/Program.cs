using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrid 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi;
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tähte;
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust;

            Console.WriteLine("Palun sisestage eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Palun sisestage number 1-3:");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch(userNumber)
            {
                case '1':
                    NameBackwards(userName);
                    break;
                case '2':
                    FirstLetter(userName);
                    break;
                case '3':
                    NameLenght(userName);
                    break;                  
            }

        }
        private static void NameBackwards(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        private static void FirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        private static void NameLenght(string userInput)
        {
            Console.WriteLine($"Sinu eesnimi on {userInput.Length} sümbolit pikk. ");
        }
    }
}
