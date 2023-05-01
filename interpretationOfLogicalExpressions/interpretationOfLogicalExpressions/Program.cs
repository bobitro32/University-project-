using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {


        static void Main(string[] args)
        {


            string input = Console.ReadLine();
            //DEFINE func3(a, b, c, d): "a & (b | c) & !d"



            string[] afterSplit = SplitMethod("\"", input);
            foreach (string line in afterSplit)
            {
                Console.WriteLine(line);
            }


        }
        public static void checkFuntion(string command, string input)
        {


            switch (command)
            {
                case "DEFINE":
                    defineFunc(input);
                    break;
                case "SOLVE":
                    //solveMethod
                    break;
                case "ALL":
                    //allMethod
                    break;
                case "FIND":
                    //findMethod
                    break;
            }

        }




        public static string[] SplitMethod(string separator, string text)
        {
            int count = 0;
            int index = 0;
            int len = 0;
            while (len < text.Length)
            {
                if (text[len] == separator[index])
                {
                    index++;
                    if (index == separator.Length)
                    {
                        index = 0;
                        count++;

                    }


                }
                else
                {
                    index = 0;

                }
                len++;

            }
            if (count == 0)
            {
                throw new ArgumentOutOfRangeException("There was not substring to split by in the input");
            }
            string[] symbols = new string[count];
            len = 0;
            index = 0;
            int position = 0;
            string currentString = "";
            while (len < text.Length)
            {

                if (text[len] != separator[index])
                {

                    currentString += text[len];

                }
                else
                {

                    index++;
                    if (index == separator.Length)
                    {
                        index = 0;

                        symbols[position] = currentString;
                        position++;
                        currentString = "";

                    }
                }

                len++;
            }

            if (currentString != "")
            {

                symbols[position] = currentString;
            }


            return symbols;


        }

        public static bool ContainsSubString(string part, string text)
        {

            int lengthOfPart = 0;
            //bool doesContain = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == part[0])
                {
                    lengthOfPart++;
                    int nextSymbolForText = i + 1;
                    int nextSymbolForPart = 1;

                    while (nextSymbolForPart < part.Length)
                    {
                        if (text[nextSymbolForText] != part[nextSymbolForPart])
                        {
                            lengthOfPart = 0;

                            break;
                        }

                        lengthOfPart++;

                        nextSymbolForText++;
                        nextSymbolForPart++;
                    }



                }

            }
            if (lengthOfPart == part.Length)
            {
                return true;
            }
            return false;


        }


        public static void defineFunc(String input)
        {
            //DEFINE func3(a, b, c, d): "a & (b | c) & !d"






        }

        public static string SubstringMethod(string input, int startIndex)
        {
            if (startIndex < 0 || startIndex >= input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }


            int len = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i >= startIndex)
                {
                    len++;
                }
            }
            if (len < 0 || startIndex + len > input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(len));
            }

            char[] chars = new char[len];

            for (int i = 0; i < len; i++)
            {
                chars[i] = input[startIndex + i];
            }

            return new string(chars);
        }


        public static int IndexOfMethod(string str, string searchValue)
        {
            if (searchValue.Length > str.Length)
            {
                return -1;
            }

            for (int i = 0; i <= str.Length - searchValue.Length; i++)
            {
                bool match = true;

                for (int j = 0; j < searchValue.Length; j++)
                {
                    if (str[i + j] != searchValue[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    return i;
                }
            }

            return -1;
        }






    }


}
