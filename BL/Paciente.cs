using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace BL
{
    public class Paciente
    {
        public static ML.Result Add(ML.Paciente paciente)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.FernandoLunaBaseEntities context = new DL.FernandoLunaBaseEntities())
                {
                    var query = context.PacienteAdd(paciente.Nombre, paciente.ApellidoPaterno, paciente.ApellidoMaterno, paciente.FechaDeNacimiento, paciente.FechaDeIngreso, paciente.Sexo, paciente.Sintomas, paciente.TipoSangre.IdTipoSangre);
                    if(query>=1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se agrego registro";
                    }
                    result.Correct = true;
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
        public static ML.Result Update(ML.Paciente paciente)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.FernandoLunaBaseEntities context = new DL.FernandoLunaBaseEntities())
                {
                    var query = context.PacienteUpdate(paciente.IdPaciente, paciente.Nombre, paciente.ApellidoPaterno, paciente.ApellidoMaterno, paciente.FechaDeNacimiento, paciente.FechaDeIngreso, paciente.Sexo, paciente.Sintomas, paciente.TipoSangre.IdTipoSangre);
                    if(query>=1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage= "No se puede actualizar";
                    }
                    result.Correct = true;
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
          
        
        public static ML.Result Delete(ML.Paciente paciente)
        {
            ML.Result result = new ML.Result();
            using(DL.FernandoLunaBaseEntities context = new DL.FernandoLunaBaseEntities())
            {
                try
                {
                    var query = context.PacienteDelete(paciente.IdPaciente);
                    if(query >0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }

                }
                catch(Exception ex)
                {
                    result.Correct = false;
                    result.ErrorMessage = ex.Message;
                }
                return result;
            }
        }
        public static ML.Result PacienteGetAll()
        {
            ML.Result result = new ML.Result();
            using (DL.FernandoLunaBaseEntities context = new DL.FernandoLunaBaseEntities())
            {
                try
                {
                    var query = context.PacienteGetAll().ToList();

                    if(query !=null)
                    {
                        result.Objects = new List<object>();
                        foreach(var obj in query)
                        {
                            ML.Paciente paciente = new ML.Paciente();

                            paciente.IdPaciente = obj.IdPaciente;
                            paciente.Nombre = obj.Nombre;
                            paciente.ApellidoPaterno = obj.ApellidoPaterno;
                            paciente.ApellidoMaterno = obj.ApellidoMaterno;
                            paciente.FechaDeNacimiento = obj.FechaDeNacimiento.ToString();
                            paciente.FechaDeIngreso = obj.FechaDeIngreso.ToString() ;
                            paciente.Sexo = obj.Sexo;
                            paciente.Sintomas = obj.Sintomas;

                            paciente.TipoSangre = new ML.TipoSangre();
                            paciente.TipoSangre.IdTipoSangre = obj.IdTipoSangre.Value;
                            

                            result.Objects.Add(paciente);
                        }
                        result.Correct=true;
                    }
                    else
                    {
                        result.Correct=false;
                    }
                }
                catch(Exception ex)
                {
                    result.Correct = false;
                    result.ErrorMessage = ex.Message;
                }
                return result;
            }
        }
        public static ML.Result GetById( int IdPaciente)
        {
            ML.Result result = new ML.Result();
            using(DL.FernandoLunaBaseEntities context = new DL.FernandoLunaBaseEntities())
            {
                try
                {
                    var query = context.PacienteGetById(IdPaciente).FirstOrDefault();
                    result.Objects = new List<object>();
                    if(query !=null)
                    {
                        ML.Paciente paciente = new ML.Paciente();

                        paciente.IdPaciente = query.IdPaciente;
                        paciente.Nombre = query.Nombre;
                        paciente.ApellidoPaterno = query.ApellidoPaterno;
                        paciente.ApellidoMaterno = query.ApellidoMaterno;
                        paciente.FechaDeNacimiento = query.FechaDeNacimiento.ToString();
                        paciente.FechaDeIngreso = query.FechaDeIngreso.ToString();
                        paciente.Sexo = query.Sexo;
                        paciente.Sintomas = query.Sintomas;

                        paciente.TipoSangre = new ML.TipoSangre();
                        paciente.TipoSangre.IdTipoSangre = query.IdTipoSangre.Value;
                       

                        result.Object = paciente;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
                catch(Exception ex)
                {
                    result.Correct= false;
                    result.ErrorMessage = ex.Message;
                }
                return result;
            }
        }
    }
}
