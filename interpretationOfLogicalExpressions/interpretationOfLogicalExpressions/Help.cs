using System;

public class Help
{


    public static string[] SplitMethod(string separator, string text)
    {
        int count = 1;
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
                    if (len != text.Length - 1)
                    {
                        count++;
                    }
                }
            }
            else
            {
                index = 0;
            }
            len++;

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
    public static int IndexOfMethod(string str, char value)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == value)
            {
                return i;
            }
        }
        return -1;
    }

    public static bool IsLetter(char c)
    {
        int ascii = (int)c;
        return (ascii >= 97 && ascii <= 122);
    }



    public static string Extract(string inputString, string charsToRemove)
    {

        string result = "";


        for (int i = 0; i < inputString.Length; i++)
        {
            char c = inputString[i];


            if (IndexOfMethod(charsToRemove, c) == -1)
            {

                result += c;
            }
        }


        return result;
    }

}
