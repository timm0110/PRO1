using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Izpit
    {
        public DateTime Datum { get; set; }
        public int Id { get; set; }
        public int Ocena { get; set; }
        public Predmet Predmet { get; set; }
        public int PredmetID { get; set; }
        public student Student { get; set; }
        public int StudentID { get; set; }

    }
}