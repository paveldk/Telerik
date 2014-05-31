using System;

class BonusScore
{

    static void Main()
    {
        //Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 

        int number;
        //Input a number and check if it's number between 0 and 999, to prevent illegal inputs
        do
        {
            Console.Write("Input a number from 0 to 999: ");
            number = int.Parse(Console.ReadLine());

            if ((number > 999) || (number < 0))
            {
                Console.WriteLine("The number isn't in the range 0-999!Please input right number!");
                Console.ReadLine();
                Console.Clear();
            }

        } while ((number) > 999 || (number < 0));

        string numberAsText = Convert.ToString(number);

        //the special inputs that i'm gonna use N times gonna make as array, array tens have first twe empty elements, becouse there aren't two digit numbers starting with 0 and these starting with 1 are in second array
        string[] tens = new String[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] TenTo19 = new String[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        //we're using the converted to text number's lenght if it's 1 the range is 0-9, if it's 2 the range is 10-99 and with 3 is 100-999
        switch (numberAsText.Length)
        {
            case 1:
                //0-9
                if (number == 0)
                {
                    Console.WriteLine("Zero");
                }
                //from 1 to 9 we're using method, becouse the digits are used in numbers - 79 is Seventy NINE
                Number1to9(number);
                break;
            case 2:
                //we're geting the 2 digits
                int firstDigit = Convert.ToInt32(numberAsText.Substring(0, 1));
                int secondDigit = Convert.ToInt32(numberAsText.Substring(1, 1));

                if (firstDigit == 1)
                {
                    //calling the special array 10 to 19
                    Console.Write(TenTo19[secondDigit] + " ");
                }
                else
                {
                    //20-99 the tens is geting from first Digit and the array, second digit is from the method Number1to9
                    Console.Write(tens[firstDigit] + " ");
                    Number1to9(secondDigit);
                }
                break;
            case 3:
                //here we need 3 digits
                firstDigit = Convert.ToInt32(numberAsText.Substring(0, 1));
                secondDigit = Convert.ToInt32(numberAsText.Substring(1, 1));
                int thirdDigit = Convert.ToInt32(numberAsText.Substring(2, 1));

                //first digit are hunderds, from the method we're getting the pronounce for hundreds and just add text "hundred"
                Number1to9(firstDigit);
                Console.Write(" hundred");

                if (secondDigit == 0)
                {
                    if (thirdDigit != 0)
                    {
                        //if second digit is 0 but third isn't i.e. 909 we need just to add third digit NINE " hundred and " NINE
                        Console.Write(" and ");
                        Number1to9(thirdDigit);
                    }
                }
                else
                {
                    if (secondDigit == 1)
                    {
                        //again special array with smth infront NINE " hundred and " {fifteen}
                        Console.Write(" and ");
                        Console.Write(TenTo19[thirdDigit] + " ");
                    }
                    else
                    {
                        //if all digits are <> 0 then we need to use the array to 929 NINE "hundred and" {sixty} NINE
                        Console.Write(" and " + tens[secondDigit] + " ");
                        Number1to9(thirdDigit);
                    }

                }
                break;

            default:
                break;
        }
        Console.ReadLine();

    }

    private static void Number1to9(int number)
    {
        if (number == 1)
        {
            Console.Write("one");
        }
        if (number == 2)
        {
            Console.Write("two");
        }
        if (number == 3)
        {
            Console.Write("three");
        }
        if (number == 4)
        {
            Console.Write("four");
        }
        if (number == 5)
        {
            Console.Write("five");
        }
        if (number == 6)
        {
            Console.Write("six");
        }
        if (number == 7)
        {
            Console.Write("seven");
        }
        if (number == 8)
        {
            Console.Write("eight");
        }
        if (number == 9)
        {
            Console.Write("nine");
        }
    }
}
