namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// This class extends the public class String
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// This method computes hash of inputed string and then using Stringbuilder returns hexadecimal values of the hash values
        /// </summary>
        /// <param name="input"> The input string </param>
        /// <returns> StringBuilder of hexadecimal values </returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// This method convert string to true, if the string contains value from the array[true", "ok", "yes", "1", "да"]
        /// </summary>
        /// <param name="input"> The input string </param>
        /// <returns> Return True if the input string contains True value</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// This method convert string to short if possible
        /// </summary>
        /// <param name="input"> The input string </param>
        /// <returns> The short value</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// This method convert string to integer if possible
        /// </summary>
        /// <param name="input"> The input string </param>
        /// <returns> The integer value</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// This method convert string to long if possible
        /// </summary>
        /// <param name="input"> The input string </param>
        /// <returns> The long value</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// This method convert string to datetime if possible
        /// </summary>
        /// <param name="input"> The input string </param>
        /// <returns> The datetime value</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// This method capitalize first letter of a string 
        /// </summary>
        /// <param name="input"> The input string </param>
        /// <returns> The string with capitalized first letter </returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                // if the string is empty or null, there is nothing to be capitalized, so it will return the inputed value
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// This method returns substring from choosen string location to choosen string location
        /// </summary>
        /// <param name="input"> The input string </param>
        /// <param name="startString"> The start string location </param>
        /// <param name="endString"> The end string location </param>
        /// <param name="startFrom"> Start from index is not a mandatory parameter. The default value will be 0(the start of the inputed string </param>
        /// <returns></returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// This method converts cyrillic letters in a given string to latin letters
        /// </summary>
        /// <param name="input"> The input string </param>
        /// <returns></returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };

            // Simply loot the cyrillic letters array and if such letter is met in the input string is changed with the corresponding latin letter from the second array
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// This method converts latin letters in a given string to cyrillic letters
        /// </summary>
        /// <param name="input"> The input string </param>
        /// <returns></returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            // Simply loot the latin letters array and if such letter is met in the input string is changed with the corresponding cyrillic letter from the second array
            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// This method converts given user name to valid one, first by converting any cyrillic letters to latin, and then removing any symbols different from letters, numbers and the symbols '\', '_', '.', ']' '[' '^'
        /// </summary>
        /// <param name="input"> The user name </param>
        /// <returns> Valid user name </returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            // The regex replace 
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// This method converts given string to valid file name, first by converting any cyrillic letters to latin, and then removing any symbols different from letters, numbers and the symbols '\', '_', '.', ']', '[', '^', '-', '+' 
        /// </summary>
        /// <param name="input"> The input string </param>
        /// <returns> Valid file name </returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }
        
        /// <summary>
        /// This method returns first N characters from a given string. If the given char count is bigger then the whole string, it returns the string itself.
        /// </summary>
        /// <param name="input"> The input string </param>
        /// <param name="charsCount"> The number of characters </param>
        /// <returns> First N characters as string </returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// This string returns extension of a given file name
        /// </summary>
        /// <param name="fileName"> The inputed file name </param>
        /// <returns> The extension of the file </returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            // We trim the fileName to several parts. Last is the extension.
            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);

            // But if there is only 1 part, or last one is empty, there is on extension
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// This method returns content type of a file, by it's extension
        /// </summary>
        /// <param name="fileExtension"> The file extension </param>
        /// <returns> The content type</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            // using build dictionary we returns the coresponding content type
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// This method converts given string to array of bytes
        /// </summary>
        /// <param name="input"> The inputed string</param>
        /// <returns> Bytes array </returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
