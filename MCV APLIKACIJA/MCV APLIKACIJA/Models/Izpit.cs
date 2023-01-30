using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCV_APLIKACIJA
{
    public class Izpit
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int Ocena { get; set; }
        public virtual Predmet Predmet { get; set; }
        public int PredmetID { get; set; }
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }
    }
}