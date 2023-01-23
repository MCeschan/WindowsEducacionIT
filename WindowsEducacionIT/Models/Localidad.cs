using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Models
{
    public class Localidad
    {

        [Key]
        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }

        public List<Estudiante> Estudiantes { get; set; }
        public List<Profesor> Profesores { get; set; }
    }
}
