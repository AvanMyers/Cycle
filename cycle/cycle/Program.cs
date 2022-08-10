using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string massage;
            int numberOfRepit;

            Console.Write("Введите сообщение: ");
            massage = Console.ReadLine();
            Console.Write("Введите количество повторений: ");
            numberOfRepit = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numberOfRepit; i++)
            {
                Console.WriteLine($"{i + 1}. {massage}");
            }
            Console.ReadKey();
        }
    }
}
