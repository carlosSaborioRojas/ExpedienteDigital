using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpedienteDigital.Models
{
    public class Civil_Status
    {
        [Key]
        public int CivilStatusID { get; set; }
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Ingresar  {0}")]
        public string Description { get; set; }

        [Display(Name = "Codigo")]
        [Required(ErrorMessage ="Ingresar  {0}")]
        public string Code { get; set; } 
        
        //Relacion  hacia la tablas Empleados 
        public virtual ICollection<Empleado> Empleados { get; set; }
 
    }
}