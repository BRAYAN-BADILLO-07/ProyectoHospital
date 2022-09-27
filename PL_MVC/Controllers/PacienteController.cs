using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Paciente paciente = new ML.Paciente();
            ML.Result result = BL.Paciente.PacienteGetAll();

            if (result.Correct)
            {
                paciente.Pacientes = result.Objects;
            }
            return View(paciente);
        }
        [HttpGet]
        public ActionResult Form(int? IdPaciente)
        {
            ML.Result resultTipoSangre = BL.TipoSangre.GetAll();
            ML.Paciente paciente = new ML.Paciente();

            paciente.TipoSangre = new ML.TipoSangre();

            if (IdPaciente == null)
            {
                paciente.TipoSangre.TipoSangres = resultTipoSangre.Objects;
                return View(paciente);
            }
            else 
            {
                ML.Result result = BL.Paciente.GetById(IdPaciente.Value);
                if(result.Correct)
                {
                    paciente =((ML.Paciente)result.Object);

                    paciente.TipoSangre.TipoSangres = resultTipoSangre.Objects;

                    return View(paciente);
                }
                else
                {
                    ViewBag.Mensaje = "Se produjo un error" + result.ErrorMessage;
                    return View("Modal");
                }
            }
           
        }
        [HttpPost]
        public ActionResult Form(ML.Paciente paciente)
        {
            ML.Result result = new ML.Result();

            if (paciente.IdPaciente == 0)
            {
                result = BL.Paciente.Add(paciente);

                if (result.Correct)
                {

                    ViewBag.Mensaje = "Registro exitoso";
                }
                else
                {
                    ViewBag.Mensaje= "ocurrio un error" + result.ErrorMessage;
                }
            }
            else
            {
                result = BL.Paciente.Update(paciente);

                if(result.Correct)
                {
                    ViewBag.Mensaje = "Se actualizo registro";
                }
                else
                {
                    ViewBag.Mensaje = "Se produjo un error" + result.ErrorMessage;
                }
            }
            return PartialView("Modal");
        }
        [HttpGet]
        public ActionResult Delete(ML.Paciente paciente)
        {
            ML.Result result = new ML.Result();
            result = BL.Paciente.Delete(paciente);
            if (result.Correct)
            {
                ViewBag.Mensaje = "Registro Eliminado con exito";
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un problema al eliminar el registo";
            }
            return PartialView("Modal");
        }
    }
}