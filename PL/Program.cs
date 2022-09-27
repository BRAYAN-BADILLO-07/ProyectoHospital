using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String resp = "";

            do
            {
                Console.WriteLine("Seleciona una opcion");
                Console.WriteLine("Agregar, Actualizar, Eliminar, GetAll o GetById");
                Console.WriteLine();
                Console.WriteLine("AgregarAseguradora, ActualizarAseguradora, EliminarAseguradora, GetAllAseguradora o GetByIdAseguradora");
                Console.WriteLine();
                Console.WriteLine("AgregarEmpresa, ActualizarEmpresa, EliminarEmpresa, GetAllEmpresa o GetByIdEmpresa");
                Console.WriteLine();
                resp = Console.ReadLine();
                string eleccion = Convert.ToString(resp);

                switch (eleccion)
                {
                    case "Agregar":
                        PL.Paciente.Add();
                        break;
                    //case "Actualizar":
                    //    PL.Usuario.Update();
                    //    break;
                    //case "Eliminar":
                    //    PL.Usuario.Delate();
                    //    break;
                    //case "GetAll":
                    //    PL.Usuario.GetAll();
                    //    break;
                    //case "GetById":
                    //    PL.Usuario.GetById();
                    //    break;
                    //case "AgregarAseguradora":
                    //    PL.Aseguradora.Add();
                    //    break;
                    //case "ActualizarAseguradora":
                    //    PL.Aseguradora.Update();
                    //    break;
                    //case "EliminarAseguradora":
                    //    PL.Aseguradora.Delete();
                    //    break;
                    //case "GetAllAseguradora":
                    //    PL.Aseguradora.GetAll();
                    //    break;
                    //case "GetByIdAseguradora":
                    //    PL.Aseguradora.GetById();
                    //    break;
                    //case "AgregarEmpresa":
                    //    PL.Empresa.Add();
                    //    break;
                    //case "ActualizarEmpresa":
                    //    PL.Empresa.Update();
                    //    break;
                    //case "EliminarEmpresa":
                    //    PL.Empresa.Delate();
                    //    break;
                    //case "GetAllEmpresa":
                    //    PL.Empresa.GetAll();
                    //    break;
                    //case "GetByIdEmpresa":
                    //    PL.Empresa.GetById();
                    //    break;
                }
                Console.WriteLine("¿Desea realizar una nueva operacion? Si/No");
                resp = Console.ReadLine();
            
            }
            while (resp == "Si" || resp == "si");
        }
    }
}
