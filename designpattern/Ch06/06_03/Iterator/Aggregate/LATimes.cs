using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterator;

namespace Iterator.Aggregate
{
    // ConcreteAggregate
    public class LATimes : INewspaper
    {        
        private string[] _reporters;
        public LATimes()
        {
            _reporters = new[] { "Ronald Smith - LA",
                                 "Danny Glover - LA",
                                 "Yolanda Adams - LA",
                                 "Jerry Straight - LA",
                                 "Rhonda Lime - LA",
                                };
        }

        public IIterator CreateIterator()
        {
            return new LATimesIterator(_reporters);
        }
    }
}
