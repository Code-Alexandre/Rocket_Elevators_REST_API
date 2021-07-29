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
        public string column_type { get; set; }
        public string number_of_floors_served { get; set; }
        public string information { get; set; }
        public string notes { get; set; }
        // public long battery_Id { get; set; }
        public long battery_id { get; set; }
        // public  Battery Battery { get; set;}
        // public List<Elevator> elevators { get; set; }
    }
}    