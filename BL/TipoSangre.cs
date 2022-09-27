﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TipoSangre
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            using(DL.FernandoLunaBaseEntities context = new DL.FernandoLunaBaseEntities())
            {
                try
                {
                    var query = context.TipoSangreGetAll().ToList();

                    if(query !=null)
                    {
                        result.Objects = new List<object>();
                        foreach(var obj in query)
                        {
                            ML.TipoSangre tipoSangre = new ML.TipoSangre();

                            tipoSangre.IdTipoSangre = obj.IdTipoSangre;
                            tipoSangre.Nombre = obj.Nombre;

                            result.Objects.Add(tipoSangre);
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
                    result.Correct=false;
                    result.ErrorMessage = ex.Message;
                }
                return result;
            }
        }
    }
}
