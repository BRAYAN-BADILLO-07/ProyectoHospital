using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Paciente
    {
        public static void Add()
        {
            ML.Paciente paciente = new ML.Paciente();
            paciente.TipoSangre = new ML.TipoSangre(); // LLAVE FORANEA

            Console.WriteLine("Ingrese el Nombre");
            paciente.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Paterno");
            paciente.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Materno");
            paciente.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa la Fecha de Nacimiento");
            paciente.FechaDeNacimiento = Console.ReadLine();

            Console.WriteLine("Ingresa el Sexo");
            paciente.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa la descripcion");
            paciente.TipoSangre.IdTipoSangre = int.Parse(Console.ReadLine());

         

            

        }
    }
}
