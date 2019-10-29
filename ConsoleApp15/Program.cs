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

            string word = a.Substring(1,l-2);
        
            return word;
        }

        static void Main(string[] args)
        {
            Substringer s = new Substringer();

            string r = s.nameLimiter("Eugene");
            
            Console.WriteLine(r);
            Console.ReadKey();

        }
    }
}
