using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Models
{
    public class Profesor
    {
        [Key]
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int? IdLocalidad { get; set; }
        [ForeignKey("IdLocalidad")]


        public Localidad Localidad { get; set; }
        public List<Planilla> Planillas { get; set; }
    }
}
