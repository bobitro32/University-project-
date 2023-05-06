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



            checkFuntion(input);


        }
        public static void checkFuntion(string input)
        {

            string command = Help.SplitMethod(" ", input)[0];


            switch (command)
            {
                case "DEFINE":

                    string function = Help.SubstringMethod(input, 7);
                    //checkValidation(function);
                    defineFunc(function);
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







        public static void defineFunc(String input)
        {
            //DEFINE func3(a, b, c, d): "a & (b | c) & !d"
            string logic = Help.SplitMethod(": \"", input)[1];
            logic = Help.Extract(logic, "\"");

            Tree tree = new Tree();
            tree.BuildExpressinTree(logic);
            tree.Print();





        }

       


    }


}
