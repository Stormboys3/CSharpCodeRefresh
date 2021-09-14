using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            LeMethod();
            ParameterMethod(8);
            VariableMethod("no");
            MoreVariables(a: 30000, b: 7000, c: 600, d: 40, e: 3);
            Re(word1: "Hello ", word2: "hooman.");
            Re(word1: "How ", word2: "you ", word3: "do?");
            Re();
            string output = Whisper("OK.");
            Console.WriteLine(output);
        }
        static void LeMethod()
        {
            Console.WriteLine("It worked.");
        }
        //The variable can only be used inside the method.
        static void ParameterMethod(int num)
        {
            
            Console.WriteLine($"My life savings is {num} dollars.");
        }
        static void VariableMethod(string msg, string dot = ".")
        {
            Console.WriteLine(msg + dot);
        }
        static void MoreVariables(int a, int b, int c, int d, int e)
        {
            Console.WriteLine(a + b + c + d + e);
        }
        //An overload is when a method has the same name, but with different numbers of variables.
        static void Re(string word1, string word2)
        {
            Console.WriteLine(word1 + word2);
        }
        static void Re(string word1, string word2, string word3)
        {
            Console.WriteLine(word1 + word2 + word3);
        }
        static void Re()
        {
            Console.WriteLine("Nothing.");
        }
        //Returns a string, so it has the string modifier right before the name.
        static string Whisper(string phrase)
        {
            //Return tells the computer to exit the method and return a value to wherever
            //the method was called.

            return phrase.ToLower();
        }
    }
}
