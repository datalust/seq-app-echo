using System;
using System.Text;

namespace Seq.App.Echo
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Console.InputEncoding = new UTF8Encoding(false);

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                Console.Error.WriteLine(line);
            }
        }
    }
}
