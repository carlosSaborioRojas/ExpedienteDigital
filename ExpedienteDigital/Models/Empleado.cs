using System;
using System.ComponentModel.DataAnnotations;

namespace ExpedienteDigital.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoID { get; set; }

        [Display(Name ="Nombre Empleado")]
        [Required(ErrorMessage ="Ingresar {0}")]
        public string Nombre { get; set; }

        [Display(Name ="Primer Apellido")]
        [Required(ErrorMessage ="Ingresar {0}")]
        public string Apellido { get; set; }

        [Display(Name ="Segundo Apellido")]
        [Required(ErrorMessage ="Ingresar{0}")]
        public string SegundoApellido { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Solo se permiten numeros")]
        public int Edad { get; set; }

        [Display(Name ="Fecha de Nacimiento")]
        [Required(ErrorMessage ="Ingresar{0}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}",ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Fecha de Ingreso")]
        [Required(ErrorMessage = "Ingresar{0}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaIngreso { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Ingresar{0}")]
        [DataType(DataType.MultilineText)]
        public string Direccion { get; set; }

        [Display(Name = "Correo Electronico")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Salario")]
        [Required(ErrorMessage = "Ingresar{0}")]
        [DisplayFormat(DataFormatString = "{0:C2}",ApplyFormatInEditMode = false)]
        public decimal Salario { get; set; }

        [Display(Name ="Numero de Cedula")]
        [Required(ErrorMessage ="Ingresar  {0}")]
        [Range(0, int.MaxValue, ErrorMessage = "Solo se permiten numeros")]
        public string  Cedula { get; set; }

        [Required(ErrorMessage = "Numero de Telefono Requerido")]
        [DataType(DataType.PhoneNumber)]
        public string telefono { get; set; }
        public string Puesto { get; set; }

        /*Atributos de Relacion a tablas*/ 
        [Display(Name ="Estado del Empleado")]
        public int StateEmpleyeesId { get; set; }
        public virtual State_Employees StateEmployees { get; set; }

        [Display(Name ="Estado Civil")]
        public int CivilStatusID { get; set; }
        public virtual Civil_Status CivilStatus { get; set; }

        
        [Display(Name ="Tipo de Documento")]
        public int DocumentTypeId { get; set; }
        public virtual Document_Type DocumentType { get; set; }

    }
}