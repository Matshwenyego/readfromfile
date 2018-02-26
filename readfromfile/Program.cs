using System;
//Include Input/Output library 
using System.IO;

namespace readfromfile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("info.txt");

            string line;

            while (!reader.EndOfStream) {
                line = reader.ReadLine();
                Console.WriteLine(line);
                
            }
            Console.ReadLine();
        }
    }
}
