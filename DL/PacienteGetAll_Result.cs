//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    
    public partial class PacienteGetAll_Result
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public Nullable<System.DateTime> FechaDeNacimiento { get; set; }
        public Nullable<System.DateTime> FechaDeIngreso { get; set; }
        public string Sexo { get; set; }
        public string Sintomas { get; set; }
        public Nullable<int> IdTipoSangre { get; set; }
    }
}
