using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number:");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Users\ericn\Logs\log.txt", number);

            Console.WriteLine("The number you chose is:");
            string text = File.ReadAllText(@"C:\Users\ericn\Logs\log.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
