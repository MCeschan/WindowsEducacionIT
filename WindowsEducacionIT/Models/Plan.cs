using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Models
{
    [Table("Plan")]
    public class Plan
    {

        [Key]
        public int IdPlan { get; set; }
        public string Nombre { get; set; }
        public int IdCarrera { get; set; }
        public Carrera Carrera { get; set; }
    }
}
