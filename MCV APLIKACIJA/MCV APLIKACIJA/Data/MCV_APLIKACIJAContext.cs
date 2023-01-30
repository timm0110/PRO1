using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MCV_APLIKACIJA.Data
{
    public class MCV_APLIKACIJAContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MCV_APLIKACIJAContext() : base("name=MCV_APLIKACIJAContext")
        {
        }

        public System.Data.Entity.DbSet<MCV_APLIKACIJA.Student> Students { get; set; }

        public System.Data.Entity.DbSet<MCV_APLIKACIJA.Predmet> Predmets { get; set; }

        public System.Data.Entity.DbSet<MCV_APLIKACIJA.Izpit> Izpits { get; set; }
    }
}
