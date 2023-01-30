using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MCV_APLIKACIJA
{
    public class Student
    {
        public int Id { get; set; }
       
        public string Ime { get; set; }
        
        public string Priimek { get; set; }
    }
}