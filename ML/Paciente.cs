﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string FechaDeIngreso { get; set; }
        public string Sexo { get; set; }
        public string Sintomas { get; set; }
        public int IdTipoSangre { get; set; }

        //LLAVE FORANEA
        public ML.TipoSangre TipoSangre { get; set; }
        public List<object> Pacientes { get; set; }


    }
}
