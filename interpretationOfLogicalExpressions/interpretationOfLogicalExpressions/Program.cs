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
            string res = SubstringMethod(input, 24);
            Console.WriteLine(res);


            //string[] afterSplit = SplitMethod(' ', input);


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




        public static string[] SplitMethod(char separator, string text)
        {
            int count = 1;
            foreach (char symbol in text)
            {
                if (symbol == separator)
                {
                    count++;
                }
            }
            string[] symbols = new string[count];
            string currentValue = "";
            foreach (char symbol in text)
            {

                if (symbol == separator)
                {
                    symbols[symbols.Length - count] = currentValue;
                    count--;
                    currentValue = "";
                }
                else
                {
                    currentValue += symbol;

                }
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



    }


}
