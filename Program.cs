using System;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string huh = "Mogus.";

            //Use backslash for quote
            string what = "And he said I quote,\"Big chungus.\"";
            string funny = "Fortnite";
            string funny2 = " Funnies";
            string funny3 = " #2";
            string ok = funny + funny2 + funny3;
            string answer1 = "cats";
            string answer2 = "dogs";
            string LengthStr = "A9R5G4D2V36D";
            string IndexStr = "soekgjowelodjfgit";
            string Substr = " very cool guy";
            string Brack = "you";
           
            //Dont forget the $
            string statement = $"I like {answer1} and {answer2}.";

            Console.WriteLine(huh);

            //Console.Write doesnt make a new line unlike Console.WriteLine
            //"/n" spaces out the strings
            Console.Write("\n");
            Console.WriteLine(what);
            Console.Write("\n");
            Console.WriteLine(ok);
            Console.Write("\n");
            Console.WriteLine(statement);
            Console.Write("\n");

            //.Length says how long the string is
            Console.WriteLine(LengthStr.Length);

            Console.Write("\n");

            //.IndexOf() sees if something exists in the string, if so it returns 1
            Console.WriteLine(IndexStr.IndexOf("o"));
            int cool = Substr.IndexOf("cool guy");
            int BrackIndex = Brack.IndexOf("y");

            Console.Write("\n");

            //.Substring seperate string to a smaller bit
            string coolMan = Substr.Substring(cool);
            Console.WriteLine(coolMan);

            Console.Write("\n");

            //Brackets are used to find a character in a string
            char yep = Brack[BrackIndex];
            Console.WriteLine(yep);

            Console.Write("\n");

            //.ToUpper() capitalizes a string
            string cap = "among us".ToUpper();
            Console.WriteLine(cap);

            Console.Write("\n");

            //.ToLower() lowercases a string
            string low = "NO".ToLower();
            Console.WriteLine(low);
        }
    }
}
