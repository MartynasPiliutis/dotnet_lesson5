using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                skaiciai.Add(rnd.Next(1,100));
            }
            Console.WriteLine("Sukurtas listas:");
            skaiciai.ForEach(Console.WriteLine);
            Console.ReadLine();

            Console.WriteLine("Lyginiai listo elementai:");
            skaiciai.ForEach(item =>
            {
                int s = Convert.ToInt32(item);
                if (s%2 == 0)
                {
                    Console.WriteLine(s);
                }
            });
            Console.ReadLine();
        }
    }
}
