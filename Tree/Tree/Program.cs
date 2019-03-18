using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
class Program
    {
        static void Main(string[] args)
        {
            Tree t = new Tree();
            t.Insert("Cемен");
            t.Insert("Петро");
            t.Insert("Дмитро");
            t.Insert("Марчйка");
            t.Insert("Люда");
            t.Insert("Оксанка");

            Console.WriteLine(t.Display(t));
            Tree s = t.Search("Оксанка");
            Console.WriteLine(s.Display(s));
            t.Remove("Петро");
            Console.WriteLine(t.Display(t));
            Console.Read();
        }
    }

}
