using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Models
{
    [Table("Planilla")]
    public class Planilla
    {
        [Key]
        public int IdPlanilla { get; set; }
        public DateTime Fecha { get; set; }
        public List<Detalle> Detalles { get; set; }

        public int IdProfesor { get; set; }
        public Profesor Profesor { get; set; }

        public int IdMateria { get; set; }
        public Materia Materia { get; set; }

        public int IdCarrera { get; set; }
        public Carrera Carrera { get; set; }

        public int IdCurso { get; set; }
        public Curso Curso { get; set; }

    }
}
