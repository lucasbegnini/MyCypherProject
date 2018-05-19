using System;
using System.Diagnostics;

namespace MyCypherWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string _test = "o rato Roeu a roupa do rei de roma";

            Stopwatch sw = new Stopwatch();
            MyCypher _myCypher = new MyCypher();
            
            // Encypher process       
            sw.Start();
            string _out = _myCypher.Encipher(_test);
            sw.Stop();
            Console.WriteLine("Time to encypher ={0}", sw.Elapsed);
            Console.WriteLine("Cypher " + _out);

            // Decypher process
            sw.Start();
            _out = _myCypher.Decipher(_out);
            sw.Stop();
            Console.WriteLine("Time to decypher ={0}", sw.Elapsed);
            Console.WriteLine("Non Cypher " + _out);


            Console.ReadKey();

        }
    }
}
