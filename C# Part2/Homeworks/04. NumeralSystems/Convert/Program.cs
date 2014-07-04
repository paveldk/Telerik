/* 1. Write a program to convert decimal numbers to their binary representation.
 * 2. Write a program to convert binary numbers to their decimal representation.
 * 3. Write a program to convert decimal numbers to their hexadecimal representation.
 * 4. Write a program to convert hexadecimal numbers to their decimal representation.
 * 5. rite a program to convert hexadecimal numbers to binary numbers (directly).
 * 6. Write a program to convert binary numbers to hexadecimal numbers (directly).
 * 
 * I'm gonna make all tasks from 1 to 6 in one Project with a menu so user to be able to choose what convert to make. It's working only for long numbers, positive and negative.
*/
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int option = 0;
        do
        {
            // A menu to choose task:
            Console.Clear();
            Console.WriteLine("1. Convert Decimal to Binary");
            Console.WriteLine("2. Convert Binary to Decimal");
            Console.WriteLine("3. Convert Decimal to Hex");
            Console.WriteLine("4. Convert Hex to Decimal");
            Console.WriteLine("5. Convert Hex to Binary");
            Console.WriteLine("6. Convert Binary to Hex");
            Console.Write("Choose an option: ");
            option = int.Parse(Console.ReadLine());
        } 
        while (option < 1 || option > 6);

        // When the option is choosen depending from the choice a case is pick. There is check the options to be available only from 1 to 6.
        switch (option)
        {
            case 1:
                long decimalNumber = 0;
                string input = string.Empty;
                bool isLong = false;
                do
                {
                    // First we clear the screen then we add title and "-" before and after it from the beggining to the end of the Console width. That's for EVERY Choice.
                    Console.Clear();
                    string title = "Convert Decimal to Binary";
                    int titleLength = (Console.WindowWidth - title.Length) / 2;
                    Console.WriteLine("{0}{1}{0}", new string('-', titleLength), title);
                    Console.Write("Input a long value: ");
                    input = Console.ReadLine();
                    isLong = long.TryParse(input, out decimalNumber);
                }               
                while (!isLong);

                // When proper value is inputed(for this case a long one) we call the Method we need again for ever Case it's the same
                decimalNumber = Convert.ToInt64(input);
                string result = ConvertFromDecimal(decimalNumber, 2);
                Console.WriteLine("The binary represantation of long number {0} is {1}", decimalNumber, result);              
                break;
            case 2:
                long binaryNumber = 0;
                bool isBinary = true;
                do
                {
                    isBinary = true;
                    Console.Clear();
                    string title = "Convert Binary to Decimal";
                    int titleLength = (Console.WindowWidth - title.Length) / 2;
                    Console.WriteLine("{0}{1}{0}", new string('-', titleLength), title);
                    Console.Write("Input a binary value(with leading 0 for positive and leading 1 for negative for 64 bits numbers): ");
                    input = Console.ReadLine();
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] - 48 > 1 || input[i] - 48 < 0)
                        {
                            isBinary = false;    
                        }    
                    }
                }
                while (!isBinary);

                binaryNumber = ConvertToDecimal(input, 2);
                Console.WriteLine("The binary represantation of long number {0} is {1}", input, binaryNumber);
                break;
            case 3:
                decimalNumber = 0;
                isLong = false;
                do
                {
                    Console.Clear();
                    string title = "Convert Decimal to Hexadecimal";
                    int titleLength = (Console.WindowWidth - title.Length) / 2;
                    Console.Write("{0}{1}{0}", new string('-', titleLength), title);
                    Console.Write("Input a long value: ");
                    input = Console.ReadLine();
                    isLong = long.TryParse(input, out decimalNumber);
                }
                while (!isLong);
                decimalNumber = Convert.ToInt64(input);
                result = ConvertFromDecimal(decimalNumber, 16);
                Console.WriteLine("The binary represantation of long number {0} is 0x{1}", decimalNumber, result);
                break;
            case 4:
                bool isHex = true;
                do
                {
                    char[] hexLetters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
                    isHex = true;
                    Console.Clear();
                    string title = "Convert Hexadecimal to Decimal";
                    int titleLength = (Console.WindowWidth - title.Length) / 2;
                    Console.Write("{0}{1}{0}", new string('-', titleLength), title);

                    // I simply couldn't make it work for negative...all examples in the net is using Convert.ToInt32(hexValue, 16);
                    Console.Write("Input a hexadecimal value(positive): ");
                    input = Console.ReadLine();
                    input = input.ToUpper();
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (!hexLetters.Contains(input[i]))
                        {
                            isHex = false;
                        }
                    }
                }
                while (!isHex);

                binaryNumber = ConvertToDecimal(input, 16);
                Console.WriteLine("The decimal represantation of hex number 0x{0} is {1}", input, binaryNumber);
                break;
            case 5:
                isHex = true;
                do
                {
                    char[] hexLetters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
                    isHex = true;
                    Console.Clear();
                    string title = "Convert Hexadecimal to Binary";
                    int titleLength = (Console.WindowWidth - title.Length) / 2;
                    Console.Write("{0}{1}{0}", new string('-', titleLength), title);

                    // again only for positive
                    Console.Write("Input a hexadecimal value(positive): ");
                    input = Console.ReadLine();
                    input = input.ToUpper();
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (!hexLetters.Contains(input[i]))
                        {
                            isHex = false;
                        }
                    }
                }
                while (!isHex);

                Console.WriteLine("The binary represantation of hex number 0x{0} is {1}", input, HexToBin(input));
                break;
            case 6:
                binaryNumber = 0;
                isBinary = true;
                do
                {
                    isBinary = true;
                    Console.Clear();
                    string title = "Convert Binary to Hexadecimal";
                    int titleLength = (Console.WindowWidth - title.Length) / 2;
                    Console.WriteLine("{0}{1}{0}", new string('-', titleLength), title);
                    Console.Write("Input a binary value: ");
                    input = Console.ReadLine();
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] - 48 > 1 || input[i] - 48 < 0)
                        {
                            isBinary = false;
                        }
                    }
                }
                while (!isBinary);

                Console.WriteLine("The hexadecimal represantation of binary number {0} is 0x{1}", input, BinToHex(input));
                break;
            default:
                break;
        }
    }

    // This metod is only for task 6 - we get the length of the inputed Binary number and add leading zeros depending on the length of the number. We do that, becouse we convert simply by deviding the number to four digits parts and print Hex value of this four digit parts 0000 is 0 1111 is F
    static string BinToHex(string bin)
    {
        int needingZeros = bin.Length % 4;
        string result = string.Empty;
        for (int i = 0; i < needingZeros; i++)
        {
            bin = "0" + bin;    
        }

        for (int i = 0; i < bin.Length; i += 4)
        {
            string fourDigits = " " + bin[i] + bin[i + 1] + bin[i + 2] + bin[i + 3];

            switch (fourDigits)
            {
                case "0000":
                    result = result + "0";    
                    break;
                case "0001":
                    result = result + "1";
                    break;
                case "0010":
                    result = result + "2";
                    break;
                case "0011":
                    result = result + "3";
                    break;
                case "0100":
                    result = result + "4";
                    break;
                case "0101":
                    result = result + "5";
                    break;
                case "0110":
                    result = result + "6";
                    break;
                case "0111":
                    result = result + "7";
                    break;
                case "1000":
                    result = result + "8";
                    break;
                case "1001":
                    result = result + "9";
                    break;
                case "1010":
                    result = result + "A";
                    break;
                case "1011":
                    result = result + "B";
                    break;
                case "1100":
                    result = result + "C";
                    break;
                case "1101":
                    result = result + "D";
                    break;
                case "1110":
                    result = result + "E";
                    break;
                case "1111":
                    result = result + "F";
                    break;
                default:
                    break;
            }
        }

        return result;
    }

    // Similar to the Method for task 6 this is for task 5 and do the opposite. We get the number and return four digits number depending on hex "digit" 0 is 0000 F is 1111
    static string HexToBin(string hex)
    {
        string result = string.Empty;
        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case '0':
                    result = result + "0000";
                    break;
                case '1':
                    result = result + "0001";
                    break;
                case '2':
                    result = result + "0010";
                    break;
                case '3':
                    result = result + "0011";
                    break;
                case '4':
                    result = result + "0100";
                    break;
                case '5':
                    result = result + "0101";
                    break;
                case '6':
                    result = result + "0110";
                    break;
                case '7':
                    result = result + "0111";
                    break;
                case '8':
                    result = result + "1000";
                    break;
                case '9':
                    result = result + "1001";
                    break;
                case 'A':
                    result = result + "1010";
                    break;
                case 'B':
                    result = result + "1011";
                    break;
                case 'C':
                    result = result + "1100";
                    break;
                case 'D':
                    result = result + "1101";
                    break;
                case 'E':
                    result = result + "1110";
                    break;
                case 'F':
                    result = result + "1111";
                    break;
                default:
                    break;
            }             
        }

        return result.TrimStart('0'); 
    }

    // This method is for any Convert to Decimal in our case from Binary and from hex. As arguments we need the number and the numeric system we want to transfer from. We simply multiply every position to a concrete multiplier for it's position. For binary - 1,2,4,8,16.... for hex 1,16,256...
    static long ConvertToDecimal(string binaryNumber, int numeric)
    {
        long result = 0;
        int multiplier = 1;

        binaryNumber = binaryNumber.TrimStart('-');
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            result = result + ((long)(binaryNumber[i] - 48) * multiplier);
            multiplier *= numeric;
        }

        // For Decimal numbers ff the length is 64 bit(long value) and the leading is 1 so we want negative number that's why in this case we add to result the min value for the long
        if (binaryNumber.Length == 64 && binaryNumber[0].Equals('1') && numeric == 2)
        {
            return long.MinValue + result;
        }
        else
        {
            return result;
        }
    }

    // This method is for convert FROM decimal to any other, in our case to Hex and Bin. Method works with devinding a number to it's numeric base and getting the remainder of this action. 
    static string ConvertFromDecimal(long decimalNumber, int numeric)
    {
        long remainder;
        string result = string.Empty;
        bool negative = false;

        // if the number is negative we add to it's value the minimum value for long numbers
        if (decimalNumber < 0)
        {
            decimalNumber = decimalNumber + long.MinValue;
            negative = true;
        }

        // then we delete to the numeric system we want and get the reminder, if the reminder is bigger than 9(Hex) we convert it to letter
        while (decimalNumber > 0)
        {
            remainder = decimalNumber % numeric;
            decimalNumber /= numeric;
            if (remainder > 9)
            {
                switch (remainder)
                {
                    case 10:
                        result = "A" + result;
                        break;
                    case 11:
                        result = "B" + result;
                        break;
                    case 12:
                        result = "C" + result;
                        break;
                    case 13:
                        result = "D" + result;
                        break;
                    case 14:
                        result = "E" + result;
                        break;
                    case 15:
                        result = "F" + result;
                        break;
                    default:
                        break;
                }        
            }
            else
            {
                result = remainder.ToString() + result;
            }          
        }

        // if we convert to Decimal and the number is negative we need to add one "1" for sign.
        if (numeric == 2 && negative == true)
        {
            result = "1" + result;                
        }

        // if we convert to Hex and the number is negative we need to remove one leading "7"
        if (numeric == 16 && negative == true)
        {
            result = result.TrimStart('7');
        }

        return result;
    }
}
