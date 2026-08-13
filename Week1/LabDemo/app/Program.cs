using System;
namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Message myMessage1 = new Message("Hello - first Message object ID is 103429611");
            myMessage1.Print();

            Message myMessage2 = new Message("Hello - second Message object ID is YYY");
            myMessage2.Print();
            //This is a comment line
            int a = 10;
            int b = 20;
            int c = a + b;
            string prefix_string = "COS2007";
            string suffix_string = "hello1";

            Console.WriteLine(prefix_string + " " + suffix_string);
        }
    }
}