using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Models
{
    [Table("Evaluacion")]
    public class Evaluacion
    {
        [Key]
        public int IdEvaluacion { get; set; }
        public int Nota { get; set; }

        public int IdEstudiante { get; set; }

        public Estudiante Estudiante { get; set; }
        public int IdTipo { get; set; }
        public Tipo Tipo { get; set; }
        public int IdDetalle { get; set; }
        public Detalle Detalle { get; set; }
    }
}
