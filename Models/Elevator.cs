using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace FactInterventionApi.Models
{
    public class Elevator
    {
        [Key]
        public long Id { get; set; }
        public string Status { get; set; }
        // public long column_Id { get; set; }
        public  Column Column { get; }
        public virtual int column_id { get; set; }
    }
}    