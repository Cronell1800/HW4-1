using System.Threading.Channels;

namespace Repeted_number
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region RepetedNumber: Version1
            /*Console.Write("Enter a number: ");
            string userInputNumber = Console.ReadLine();

            string strOfNumbers = "";

            while (userInputNumber != "0")
            {
                if (int.TryParse(userInputNumber, out int parser))
                {
                    if (userInputNumber.Contains("0"))
                    {
                        if (userInputNumber.Length == 1)
                        {
                            strOfNumbers += userInputNumber;
                            break;
                        }
                        else
                        {
                            int index = userInputNumber.IndexOf("0");
                            userInputNumber = userInputNumber.Substring(0, index + 1);
                            strOfNumbers += userInputNumber;
                            break;
                        }

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
            Console.WriteLine();
            Console.WriteLine(strOfNumbers);
            Console.WriteLine();

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


        }*/
        #endregion



        int counter = 1, maxCounter = 1, prevNum = 0;
            int finderN = 0;
            Console.Write("Kiriting : ");
            string str = Console.ReadLine();
            string result = "";
            bool shart = str.Contains('0');
            while (!shart)
            {
                Console.Write("Kiriting : ");
                result += str;
                str = Console.ReadLine();
                shart = str.Contains('0');
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0')
                {
                    break;
                }
                result += str[i].ToString();
            }
            string res2 = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsDigit(result[i]))
                    res2 += result[i].ToString();
            }

            for (int i = 0; i < res2.Length - 1; i++)
            {
                if (res2[i + 1] == res2[i])
                {
                    counter++;
                }
                else if (prevNum == 0)
                {
                    prevNum = res2[i + 1] - '0';
                }
                else
                {
                    if (maxCounter <= counter)
                    {
                        maxCounter = counter;
                        finderN = prevNum;
                    }
                    prevNum = res2[i + 1] - '0';
                    counter = 1;
                }
            }
            Console.WriteLine($" {finderN} soni {maxCounter} marta ");

        }
    }
}