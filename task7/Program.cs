using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    public class Program
    {
        public static double MultiplyBy2(double x)
        {
            return x * 2;
        }
        static void Main(string[] args)
        {
                
                Console.WriteLine(MultiplyBy2(4));

        }
    }
}

