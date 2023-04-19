using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {

       
        static void Main(string[] args)
        {
            

            String input = Console.ReadLine();
            checkCommand(input);
            String[] afterSplit = SplitMethod(' ',input);
            foreach (String a in afterSplit) {
                Console.WriteLine(a);
            }
            
        }
        public static void checkCommand(String input) {
            String command = "";
            foreach (char symbol in input) {
                if (symbol == ' ') {
                    break; 
                }
                command += symbol;
            }

            switch (command) {
                case "DEFINE":
                    defineFunc(input);
                    break;
                case "SOLVE":
                    break;
                case "ALL":
                    break;
                case "FIND":
                    break;
            }

        }

        public static void defineFunc(String input)
        {

            //DEFINE func1(a, b): "a & b"
            //DEFINE func4(a, b, c): "a & b | c | !d" -> give bug, d is not defined

            string[] functionZandCondition = new string[2];
            string currentExpresstion = "";

            for (int startingSymbol = "DEFINE".Length +1; startingSymbol < input.Length; startingSymbol++)

            {
                // If the currentSymbol == : -> I add the string to the array and after that refresh the string and continue to the next command
                if (input[startingSymbol] == ':') {
                    functionZandCondition[0] = currentExpresstion;
                    currentExpresstion = "";
                    continue;
                }
                //here i check if the current symbol is  diffrent from a quotation mark or space and if it is then i add it to the string ( that's how i build the string)
                if (input[startingSymbol] != ' '  && input[startingSymbol] != '"') {
                    currentExpresstion += input[startingSymbol];  
                }
                // here i add the last string _> the expression so after that i know the expression is the second string in the array, so i can access it easier to the tree
                if (startingSymbol == input.Length - 1) {
                    functionZandCondition[1] = currentExpresstion;
                    break;
                }
            }

        }


        public static string[] SplitMethod(char separator,string text ) {
            int count = 1;
            foreach (char symbol in text) {
                if (symbol == separator) { 
                    count++;
                }
            }
            string[] symbols = new string[count];
            String currentValue = "";
            foreach (char symbol in text)
            {
      
                if (symbol == separator)
                {
                    symbols[symbols.Length - count] = currentValue;
                    count--;
                    currentValue = "";
                }
                else {
                    currentValue += symbol;        

                }
            }
            return symbols;

        
        }


    }


}
