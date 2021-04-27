using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PP_LAB_4.Models
{
    public class przykladowa_klasa
    {
        
    public int ID { get; set; }
        public string Tytuł { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataWydania { get; set; }
        public string Gatunek { get; set; }
        public string Platforma { get; set; }
        public decimal Cena { get; set; }
    }
}
