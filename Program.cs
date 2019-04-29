using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        class Repeater
        {
            public int position;
            int range;
            int count;
            public Repeater(int position, int range, int count)
            {
                this.position = position;
                this.range = range;
                this.count = count;
            }

            public string Repeat(string core)
            {
                try
                {
                    var sub = core.Substring(position - range, range);
                    var insert = "";
                    for (int i = 0; i < count; i++)
                    {
                        insert += sub;
                    }
                    return insert;
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static void podziel(string b)
        {
            string[] lb = Regex.Split(b, "([\\(\\)])");

            string core = "";
            int position = 0;
            int resultLenDiff = 0;

            LinkedList<Repeater> repeaters = new LinkedList<Repeater>();

            for (int i = 0; i < lb.Length; i++)
            {
                var row = lb[i];

                if(row == "(")
                {
                    i++;
                    string[] rep = lb[i].Split('x');
                    int range;
                    int count;
                    if(Int32.TryParse(rep[0], out range) && Int32.TryParse(rep[1], out count))
                    {
                        var repeater = new Repeater(position, range, count);
                        repeaters.AddLast(repeater);
                    }
                }
                else if(row != ")")
                {
                    core += row;
                    position += row.Length;
                }
            }

            string result = core;

            foreach (var repeater in repeaters)
            {
                var input = repeater.Repeat(core);
                result = result.Insert(repeater.position + resultLenDiff, input);
                resultLenDiff += input.Length;
            }

            Console.WriteLine(result);

            return;

        }

        static void Main(string[] args)
        {
            string a = "Ala(2x2) ma ko(10x4)t(2x3)a";
            podziel(a);
            Console.ReadLine();

        }
        //static void Main(string[] args)
        //{
            //var c1 = new Class1(5);
            //var c2 = new Class2("abc");
            //Class3 c3 = new Class3();

            //c3.assign(c1);
            //c3.assign(c2);

            //Console.WriteLine(c3.name);
            //Console.WriteLine(c3.number);

            //System.Console.Beep();
        //}
    }
}
