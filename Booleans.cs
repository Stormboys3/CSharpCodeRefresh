using System;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Answer1 = true;
            bool Answer2 = false;

            Console.WriteLine(Answer1);
            Console.WriteLine(Answer2);

            //== returns true if the 2 values are equal
            bool equation1 = 32 == 32.00;
            Console.WriteLine(equation1);

            //!= returns true if the 2 values are not equal.
            bool equation2 = 128 != 128;
            Console.WriteLine(equation2);

            bool equation3 = 36 < 45;
            Console.WriteLine(equation3);
            bool equation4 = 98 > 110;
            Console.WriteLine(equation4);

            //<= and >= means less than or equal to and greater than or equal to
            bool equation5 = 47 <= 64;
            Console.WriteLine(equation5);
            bool equation6 = 58 >= 78;
            Console.WriteLine(equation6);

            //&& means if both expressions say true then it will return true
            bool OperationBool1 = true;
            bool OperationBool2 = true;
            bool operation1 = OperationBool1 && OperationBool2;
            Console.WriteLine(operation1);

            //|| means at least 1 expression has to be true
            bool operation2 = ((68 < 3) || (89 > 3));
            Console.WriteLine(operation2);

            //! always turns as the opposite
            bool OperationBool3 = true;
            bool operation3 = !OperationBool3;
            Console.WriteLine(operation3);
        }
    }
}
