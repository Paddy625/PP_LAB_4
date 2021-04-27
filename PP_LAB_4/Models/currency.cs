using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PP_LAB_4.Models
{
    public class currency
    {
        public int ID { get; set; }
        public string record_date { get; set; }
        public string name { get; set; }
        public decimal exchange { get; set; }
    }
}
