using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomValueUniformDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "randValue.txt";
            int n = 10000;
            int startValue = 16 + 151;
            dynamic x = startValue;
            List<dynamic> listOfValue = new List<dynamic>();
            for (int i = 0; i < n; i++)
            {
                x = GetRndVal(x);
                listOfValue.Add(x);
            }
            WriteFile(path, listOfValue);
            Console.WriteLine("File is done");
            Console.ReadLine();
        }
        static dynamic GetRndVal(dynamic startValue)
        {
            dynamic q = 65536;
            int k1 = 25173;
            int k0 = 13849;
            return (k1 * startValue + k0) % q;
        }
        static void WriteFile(string path, List<dynamic> list)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "", Encoding.Unicode);
                Console.WriteLine("File created !");
            }
            foreach (var lists in list)
            {
                String temp = lists.ToString() + Environment.NewLine;
                File.AppendAllText(path, temp, Encoding.Unicode);
            }
        }
    }
}
