using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {

       
        static void Main(string[] args)
        {
            

            string input = Console.ReadLine();
            Console.WriteLine(ContainsSubString("she",input));
            
            string[] afterSplit = SplitMethod(' ',input);
           
            
        }
        public static void checkCommand(string command,string input) {
            

            switch (command) {
                case "DEFINE":
                    //defineFunc(input);
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

        


        public static string[] SplitMethod(char separator,string text ) {
            int count = 1;
            foreach (char symbol in text) {
                if (symbol == separator) { 
                    count++;
                }
            }
            string[] words = new string[count];
            string currentValue = "";
            foreach (char symbol in text)
            {
      
                if (symbol == separator)
                {
                    words[words.Length - count] = currentValue;
                    count--;
                    currentValue = "";
                }
                else {
                    currentValue += symbol;        

                }
            }
            return words;

        
        }

        public static bool ContainsSubString(string part , string text) { 
        
            
            //bool doesContain = false;
            int counter = 0;
            for(int i = 0; i < text.Length; i++) {
                if (text[i] == part[counter])
                {
                    
                    counter++;

                }
                else {
                    counter = 0;

                
                }

                if (counter == part.Length)
                {
                    return true;
                }

            }
            
            return false;

        
        }


    }


}
  /*lengthOfPart++;
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
                    }*/