using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FactInterventionApi.Models
{
    public partial class Battery
    {
        [Key]
        public int id { get; set; }
        public string Status { get; set; }
        // public long Building_Id { get; set; }

        public virtual int building_id { get; set;}
        public  Building Building { get; set;}

        public virtual ICollection<Column> Columns { get; set;}
    }
}        