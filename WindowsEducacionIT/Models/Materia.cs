using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducacionIT.Models
{
    public class Materia
    {
        [Key]
        public int IdMateria { get; set; }
        public string Nombre { get; set; }
        public List<Planilla> Planillas { get; set; }
    }
}
