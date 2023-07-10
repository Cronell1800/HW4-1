using System.Threading.Channels;

namespace Repeted_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string userInputNumber = Console.ReadLine();

            string strOfNumbers = "";

            while (userInputNumber != "0") 
            { 
                if (int.TryParse(userInputNumber, out int parser))
                {
                    if (userInputNumber.Contains("0"))
                    {
                        strOfNumbers += userInputNumber;
                        break;
                    } 

                    else
                    {
                        strOfNumbers += userInputNumber;
                        Console.Write("Enter a number: ");
                        userInputNumber = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number without text");
                    Console.Write("Enter a number: ");
                    userInputNumber = Console.ReadLine();
                }
                
            }

            if (userInputNumber == "0")
            {
                strOfNumbers += userInputNumber;
            }

            Console.WriteLine(strOfNumbers);

            char lastCheckedNumber = '0';
            int repetedNumberCounter = 0;
            int biggestAmountRepetedNumber = 0;
            string mostRepetedNumber = string.Empty;

            for (int i = 0; i < strOfNumbers.Length; i++)
            {
                if (strOfNumbers[i] == lastCheckedNumber) 
                {
                    repetedNumberCounter++;
                }
                else
                {
                    repetedNumberCounter = 1;
                    lastCheckedNumber = strOfNumbers[i];
                }

                if (repetedNumberCounter >= biggestAmountRepetedNumber)
                {
                    biggestAmountRepetedNumber = repetedNumberCounter;
                    mostRepetedNumber = Convert.ToString(strOfNumbers[i]);
                }
            }

            Console.WriteLine("The most repeted number was: " + mostRepetedNumber + ". It was repeted: " + biggestAmountRepetedNumber + " times.");


        }
    }
}