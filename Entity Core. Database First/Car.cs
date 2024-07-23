using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Core._Database_First
{
    internal class Car
    {
        public int Id { get; set; }
        public string Brand {  get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string ST_Number { get; set; }

        public override string ToString()
        {
            return $"{Brand} - {Model} - {Year} - {ST_Number}";
        }
    }
}
