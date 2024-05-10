﻿using ADSProyect.Interfaces;
using ADSProyect.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADSProyect.Controllers
{
    [Route("api/estudiantes")]
    public class EstudiantesController : ControllerBase
    {
        private readonly IEstudiante estudiante;
        private const string COD_EXITO = "000000";
        private const string COD_ERROR = "999999";
        private string pCodRespuesta;
        private string pMensajeUsuario;
        private string pMensajeTecnico;

        public EstudiantesController(IEstudiante estudiante)
        {
            this.estudiante = estudiante;
        }


        [HttpPost("agregarEstudiante")]

        public ActionResult<string> AgregarEstudiante([FromBody] Estudiante estudiante)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);

                }

                int contador = this.estudiante.AgregarEstudiante(estudiante);

                if (contador > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Estudiante agregado correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;

                }
                else
                {

                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al agregar estudiante";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("actualizarEstudiante/{idEstudiante}")]

        public ActionResult<string> ActualizarEstudiante(int idEstudiante, [FromBody] Estudiante estudiante)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);

                }

                int contador = this.estudiante.ActualizarEstudiante(idEstudiante, estudiante);

                if (contador > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Estudiante actualizado correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;

                }
                else
                {

                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al actualizar estudiante";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("eliminarEstudiante/{idEstudiante}")]

        public ActionResult<string> EliminarEstudiante(int idEstudiante)
        {
            try
            {
                bool eliminado = this.estudiante.EliminarEstudiante(idEstudiante);

                if (eliminado)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Estudiante eliminado correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;

                }
                else
                {

                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al eliminar estudiante";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });

            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpGet("obtenerEstudiantePorID/{idEstudiante}")]

        public ActionResult<Estudiante> obtenerEstudiantePorID(int idEstudiante)
        {
            try
            {
                Estudiante estudiante = this.estudiante.ObtenerEstudiantePorID(idEstudiante);

                if (estudiante != null)
                {
                    return Ok(estudiante);

                }
                else
                {

                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Estudiante no encontrado";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });

            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpGet("obtenerEstudiantes")]

        public ActionResult<Estudiante> ObtenerTodosLosEstudiantes(int idEstudiante)
        {
            try
            {
               List<Estudiante> lstEstudiantes = this.estudiante.ObtenerTodosLosEstudiantes();

               return Ok(lstEstudiantes);

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
