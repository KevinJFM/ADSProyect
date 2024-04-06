using ADSProyect.Interfaces;
using ADSProyect.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADSProyect.Controllers
{
        [Route("api/carreras/")]
        public class CarrerasController : ControllerBase
        {
            private readonly ICarrera carrera;
            private const string COD_EXITO = "000000";
            private const string COD_ERROR = "999999";
            private string pCodRespuesta;
            private string pMensajeUsuario;
            private string pMensajeTecnico;

            public CarrerasController(ICarrera carrera)
            {
                this.carrera = carrera;
            }

            [HttpPost("agregarCarrera")]

            public ActionResult<string> AgregarCarrera([FromBody] Carrera carrera)
            {
                try
                {
                    int contador = this.carrera.AgregarCarrera(carrera);
                    if (contador > 0)
                    {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Carrera agregada correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                    else
                    {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al agregar carrera";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                    return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
                }
                catch (Exception)
                {
                    throw;
                }
            }

            [HttpPut("actualizarCarrera/{idCarrera}")]
            public ActionResult<string> ActualizarCarrera([FromBody] Carrera carrera)
            {
                try
                {
                    int contador = this.carrera.ModificarCarrera(carrera.IdCarrera, carrera);
                    if (contador > 0)
                    {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Carrera actualizada correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                    else
                    {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al actualizar carrera";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                    return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
                }
                catch (Exception)
                {
                    throw;
                }
            }

        [HttpDelete("eliminarCarrera/{idCarrera}")]
        public ActionResult<string> EliminarCarrera(int idCarrera)
        {
            try
            {
                bool resultado = this.carrera.EliminarCarrera(idCarrera);
                if (resultado)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Carrera eliminada correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al eliminar carrera";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("consultarCarreraPorID/{idCarrera}")]
        public ActionResult<Carrera> ConsultarCarreraPorID(int idCarrera)
        {
            try
            {
                Carrera carrera = this.carrera.ConsultarCarreraPorID(idCarrera);
                if (carrera != null)
                {
                    return Ok(carrera);
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Carrera no encontrada";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                    return NotFound(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("consultarCarreras")]
            public ActionResult<List<Carrera>> ConsultarCarreras()
            {
                try
                {
                    List<Carrera> lstCarreras = this.carrera.ConsultarCarreras();
                    return Ok(lstCarreras);
                }
                catch (Exception)
                {
                    throw;
                }
            }

           
        }
}
