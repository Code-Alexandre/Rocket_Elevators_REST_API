using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FactInterventionApi.Models
{
    public class Building
    {
        [Key]
        public int id { get; set; }
        public int customer_Id {get; set;}
        public virtual ICollection<Battery> Batteries { get; set;}
        public  Customer Customer { get; set; }

    }
}
