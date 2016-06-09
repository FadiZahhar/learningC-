using Iterator.Aggregate;
using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            INewspaper nyt = new NYTimes();
            INewspaper lat = new LATimes();

            IIterator nytIterator = nyt.CreateIterator();
            IIterator latIterator = lat.CreateIterator();

            Console.WriteLine("--------   NYTimes");
            PrintReporters(nytIterator);

            Console.WriteLine("--------   LATimes");
            PrintReporters(latIterator);

            Console.ReadLine();
        }

        static void PrintReporters(IIterator iterator) {
            iterator.First();
            while(!iterator.IsDone()){
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
