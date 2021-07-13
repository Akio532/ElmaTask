using System;

namespace Task
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число больше 0");
            string num = Console.ReadLine();
            int x = int.Parse(num);
            Print(x);           
        }

        static void Print(int lim, int cur = 1)
        {
            if (lim >= cur)
            {
                Console.Write(cur);
                if (cur % 3 == 0)               
                    Console.Write(" Bar ");                                   
                else                
                    Console.Write(" Foo ");
                Console.WriteLine();
                Print(lim, cur + 1);                
            }

        }
    }
}
