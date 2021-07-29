using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FactInterventionApi.Models
{
    public class Column
    {
        [Key]
        public long Id { get; set; }
        public string Status { get; set; }
        // public long battery_Id { get; set; }
        public virtual int battery_id { get; set; }
        public  Battery Battery { get; set;}
        public virtual ICollection<Elevator> Elevators { get; }
    }
}    