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
        public long Id { get; set; }
        public string Status { get; set; }
        // public long Building_Id { get; set; }

        public virtual long building_id { get; set;}
        public  Building Building { get; set;}

        public List<Column> columns { get; set; }
    }
}        