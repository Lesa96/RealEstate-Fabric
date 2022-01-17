using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class RealEstate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Price { get; set; }

        //For historyDb:
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
