namespace EncodeAndEncrypt
{
    using System;
    using System.Text;

    class EAndE
    {
        static string Encrypt(string message, string cypher)
        {
            string result = string.Empty;

            if (message.Length > cypher.Length)
            {
                result = EncryptWHenMessageIsLonger(message, cypher);
            }
            else
            {
                result = EncryptWhenCypherIsLonger(message, cypher);
            }

            return result;
        }

        private static string EncryptWHenMessageIsLonger(string message, string cypher)
        {
            StringBuilder result = new StringBuilder();

            int cypherIndex = 0;

            for (int i = 0; i < message.Length; i++)
            {
                char messageSymbol = message[i];
                char cypherSymbol = cypher[cypherIndex];

                char encryptedSymbol = EncryptSymbol(messageSymbol, cypherSymbol);

                result.Append(encryptedSymbol);

                cypherIndex++;

                if (cypherIndex == cypher.Length)
                {
                    cypherIndex = 0;
                }
            }

            return result.ToString();
        }

        private static string EncryptWhenCypherIsLonger(string message, string cypher)
        {
            StringBuilder result = new StringBuilder(message);

            int messageIndex = 0;

            for (int i = 0; i < cypher.Length; i++)
            {
                char messageSymbol = result[messageIndex];
                char cypherSymbol = cypher[i];

                result[messageIndex] = EncryptSymbol(messageSymbol, cypherSymbol);
                messageIndex++;

                if (messageIndex == message.Length)
                {
                    messageIndex = 0;
                }         
            }

            return result.ToString();
        }

        private static char EncryptSymbol(char messageSymbol, char cypherSymbol)
        {
            int messageSymbolCode = messageSymbol - 'A';
            int cypherSymbolCode = cypherSymbol - 'A';

            int xoredSymbol = messageSymbolCode ^ cypherSymbolCode;

            char encrypted = (char)(xoredSymbol + 'A');

            return encrypted;
        }

        static string Encode(string text)
        {
            StringBuilder result = new StringBuilder();

            char previousSymbol = text[0];
            int counter = 1;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == previousSymbol)
                {
                    counter++;
                }
                else
                {
                    AppendCompressed(counter, result, previousSymbol);                  
                    counter = 1;
                }

                previousSymbol = text[i];
            }

            AppendCompressed(counter, result, previousSymbol);

            return result.ToString();
        }

        static void AppendCompressed(int counter, StringBuilder result, char previousSymbol)
        {
            if (counter == 1)
            {
                result.Append(previousSymbol);
            }
            else if (counter == 2)
            {
                result.Append(new string(previousSymbol, 2));
            }
            else
            {
                result.Append(counter + previousSymbol.ToString());
            }
        }

        static void Main()
        {
            string message = Console.ReadLine();
            string cypher = Console.ReadLine();

            int lengthOfCypher = cypher.Length;

            Console.WriteLine(Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher);
        }
    }
}
