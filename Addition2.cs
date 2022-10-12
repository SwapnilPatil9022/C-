using System;

namespace Simple
{
    class Addition2
    {
        public static void Main(string[] args)
        {
            int iNo1;
            int iNo2;
            int iRet;
            
            Console.WriteLine("Enter First elements");
            iNo1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Secound elements");
            iNo2 = Convert.ToInt32(Console.ReadLine());
            
            iRet = iNo1 + iNo2;

            Console.WriteLine("{0} + {1} + {2}",iNo1,iNo2,iRet);
            Console.ReadKey();
        }
    }
}