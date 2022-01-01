using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashTableProblems;

namespace HashTableProblems
{
    public class Program
    {
        static void Main(string[] args)
        {

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "To");
            hash.Add("5", "be");


            string hash4 = hash.Get("4");
            Console.WriteLine("5th Index Value: " + hash4);

        }
    }
}