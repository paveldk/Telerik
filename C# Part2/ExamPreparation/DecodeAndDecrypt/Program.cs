namespace DecodeAndDecrypt
{
    using System;
    using System.Text;

    class Program
    {
        static string Encrypt(StringBuilder text, string cypher)
        {
            StringBuilder result = new StringBuilder();
            int otherIndex = 0;

            if (text.Length > cypher.Length)
            {
                for (int i = 0; i < text.Length; i++)
			    {
                    int xorChars = (text[i] - 'A') ^ (cypher[otherIndex] - 'A');
                    result.Append((char)(xorChars + 65));

                    otherIndex++; 
                    if (otherIndex == cypher.Length )
                    {
                        otherIndex = 0;    
                    }
			    }                     
            }
            else
            {
                for (int i = 0; i < cypher.Length; i++)
                {
                    int xorChars = (cypher[i] - 'A') ^ (text[otherIndex] - 'A');
                   // result.Append((char)(xorChars + 65));
                    text[otherIndex] = (char)(xorChars + 65);

                    otherIndex++;
                    if (otherIndex == text.Length)
                    {
                        otherIndex = 0;
                    }                   
                }
                result.Append(text);
            }
            return result.ToString();
        }

        static void Main()
        {
            string cypher = string.Empty;
            string message = Console.ReadLine();
            string cypherLength = string.Empty;

            StringBuilder encryptedMessage = new StringBuilder();
            StringBuilder realMessage = new StringBuilder();

            for (int i = message.Length - 1; i >= 0; i--)
            {
                if (!char.IsDigit(message[i]))
                {
                    break;
                }
                else
                {
                    cypherLength = message[i] + cypherLength;
                }
            }

            string count = string.Empty;

            for (int i = 0; i < message.Length - cypherLength.Length; i++)
            {               
                if (char.IsDigit(message[i]))
                {
                    count = count + message[i].ToString();                                  
                }
                else
                {
                    if (count == string.Empty)
                    {
                        count = "1";    
                    }
                    for (int j = 0; j < Convert.ToInt32(count); j++)
                    {
                        encryptedMessage.Append(message[i]);    
                    }
                    count = string.Empty;
                }
            }

            for (int i = encryptedMessage.Length - 1; i >= encryptedMessage.Length - Convert.ToInt32(cypherLength); i--)
            {
                cypher = encryptedMessage[i] + cypher;
            }

            for (int i = 0; i < encryptedMessage.Length - cypher.Length; i++)
            {
                realMessage.Append(encryptedMessage[i]);
            }

            Console.WriteLine(Encrypt(realMessage, cypher));
        }
    }
}
