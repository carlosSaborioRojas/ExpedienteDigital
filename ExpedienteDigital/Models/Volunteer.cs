using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpedienteDigital.Models
{
    public class Volunteer
    {
        [Key]
        public int VolunteerID { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Ingresar {0}")]
        public string FirtName { get; set; }
        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "Ingresar {0}")]
        public string LastName { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Solo se permiten numeros")]
        [Display(Name = "Cedula")]
        [Required(ErrorMessage = "Ingresar {0}")]
        public int IdentifyCard { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Solo se permiten numeros")]
        [Display(Name = "Edad")]
        [Required(ErrorMessage = "Ingresar {0}")]
        public int Age { get; set; }
        [Display(Name = "Telefono")]
        [DataType(DataType.Password)]
        public string Phone { get; set; }
        [Display(Name ="Celular")]
        [DataType(DataType.PhoneNumber)]
        public string Phone2 { get; set; }
        [Display(Name = "Ocupacion")]
        [Required(ErrorMessage = "Ingresar {0}")]
        public string Occupation { get; set; }
        [Display(Name ="Direccion")]
        [Required(ErrorMessage = "Ingresar {0}")]
        [DataType(DataType.MultilineText)]
        public string Addres { get; set; }
        [Display(Name ="Correo Electronico")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } 
        [Display(Name ="Comision")]
        [Required(ErrorMessage = "Ingresar {0}")]
        [DataType(DataType.MultilineText)]
        public string Commission { get; set; }
         

    }
}