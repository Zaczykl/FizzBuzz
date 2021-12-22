using System;

namespace FizzBuzz
{
    class Program
    {        
        static void Main(string[] args)
        {
            try
            {
                FizzBuzz fizzBuzz = new FizzBuzz();
                while (true)
                {
                    Console.WriteLine("Wprowadź liczbę. Jeżeli chcesz zakończyć wprowadź znak T.\n");
                    Console.WriteLine(fizzBuzz.FizzBuzzOutput(GetValidateUserNumber())+"\n");                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int GetValidateUserNumber()
        {
            string input = Console.ReadLine();
            int result;
            
            while (!int.TryParse(input, out result))
            {
                if (input.ToUpper() == "T")                
                    Environment.Exit(0);
                
                Console.WriteLine("Wprowadzono nieprawidłowe dane, spróbuj ponownie.");
                input = Console.ReadLine();
            }
            return result;
        }
    }
}
