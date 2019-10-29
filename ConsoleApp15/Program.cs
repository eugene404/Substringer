using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Substringer
    {
        public string nameLimiter(string a)
        {
            int l = a.Length;

            string word = a.Substring(1,l-1);
        
            return word;
        }
        static void Main(string[] args)
        {
            Substringer s = new Substringer();

            string name = "Eugene";
            name.Substring(0);
            //char[] list = name.ToCharArray();

            Console.WriteLine("nameLimiter method " +  );
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
