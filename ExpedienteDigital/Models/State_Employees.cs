using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpedienteDigital.Models
{
    public class State_Employees
    {
        [Key]
        public int StateEmpleyeesId { get; set; }

        [Display(Name = "Descripcion") ]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "El texto tiene que tener entre 5 a 100 letras ", MinimumLength = 5)]
        [Required(ErrorMessage = "Ingresar {0}")]
        public string Description { get; set; }


        [Display(Name ="Codigo")]
        [Required(ErrorMessage = "Ingresar {0}")]
        [StringLength(4,ErrorMessage = "El texto tiene que tener entre 1 a 4 letras ", MinimumLength = 1)]
        public string Code { get; set; }


        //Relacion con empleado
        public virtual  ICollection<Empleado> Empleado { get; set; }
    }
}