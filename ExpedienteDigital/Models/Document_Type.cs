using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpedienteDigital.Models
{
    public class Document_Type
    {
        [Key]
        public int DocumentTypeId { get; set; }
        [Display(Name ="Descripcion")]
        [Required(ErrorMessage ="Ingresar {0}")]
        public string Description { get; set; }

        [Display(Name ="Codigo")]
        [Required(ErrorMessage ="Ingresar {0}")]
        public string Code { get; set; }


        //Relacion  hacia la tablas Empleados 
        public ICollection<Empleado> Empleado { get; set; }
 
    }
}