using ADSProyect.Interfaces;
using ADSProyect.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADSProyect.Controllers
{
    [Route("api/grupos/")]
    public class GruposController : ControllerBase
    {
        private readonly IGrupo grupo;
        private const string COD_EXITO = "000000";
        private const string COD_ERROR = "999999";
        private string pCodRespuesta;
        private string pMensajeUsuario;
        private string pMensajeTecnico;

        public GruposController(IGrupo grupo)
        {
            this.grupo = grupo;
        }

        [HttpPost("agregarGrupo")]

        public ActionResult<string> AgregarGrupo([FromBody] Grupo grupo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);

                }

                int contador = this.grupo.AgregarGrupo(grupo);

                if (contador > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Grupo agregado correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al agregar grupo";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("actualizarGrupo/{idGrupo}")]
        public ActionResult<string> ActualizarGrupo(int idGrupo, [FromBody] Grupo grupo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);

                }

                int contador = this.grupo.ModificarGrupo(idGrupo, grupo);
                if (contador > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Grupo actualizado correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al actualizar grupo";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("eliminarGrupo/{idGrupo}")]
        public ActionResult<string> EliminarGrupo(int idGrupo)
        {
            try
            {
                bool resultado = this.grupo.EliminarGrupo(idGrupo);
                if (resultado)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Grupo eliminado correctamente";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Error al eliminar grupo";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("consultarGrupoPorID/{idGrupo}")]
        public ActionResult<Grupo> ConsultarGrupoPorID(int idGrupo)
        {
            try
            {
                Grupo grupo = this.grupo.ConsultarGrupoPorID(idGrupo);
                if (grupo != null)
                {
                    return Ok(grupo);
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Grupo no encontrado";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                    return NotFound(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("consultarGrupos")]
        public ActionResult<List<Grupo>> ConsultarGrupos()
        {
            try
            {
                List<Grupo> lstGrupos = this.grupo.ConsultarGrupos();
                return Ok(lstGrupos);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

