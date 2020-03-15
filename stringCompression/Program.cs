using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string: ");
            string uncompressedString = Console.ReadLine();

            //iterate through each character
            for(int i = 0; i<uncompressedString.Length;i++)
            {
                int count = 1;
                //checking if the current char matches the next char
                while ((i < uncompressedString.Length - 1) && (uncompressedString[i] == uncompressedString[i + 1]))
                {
                    count++;
                    i++;
                }
                if(count == 1)
                {
                    Console.Write(uncompressedString[i]);
                }
                else
                {
                    Console.Write(count); 
                    Console.Write(uncompressedString[i]);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("press enter to quit");
            Console.ReadLine();

        }
    }
}
