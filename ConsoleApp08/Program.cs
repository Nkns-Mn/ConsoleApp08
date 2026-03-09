using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");
            Console.Write("コンソールに文字列１を入力：");
            string message1 = Console.ReadLine();
            Console.Write("コンソールに文字列２を入力：");
            string message2 = Console.ReadLine();
            Console.WriteLine( message1 + message2 );
        }
    }
}
