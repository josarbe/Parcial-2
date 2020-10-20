using Microsoft.AspNetCore.Mvc;
using PruebaAPI.Models;
using PruebaAPI.Services;


namespace PruebaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ServicioUsuario _servicioDeUsuario;

        public UsuarioController(ServicioUsuario servicioUsuario)
        {
            _servicioDeUsuario = servicioUsuario;
        }


        /*recibe los datos */

        [HttpGet("correo/{id}/contrasena/{password}")]
        public ActionResult Post(string id, string contrasena)
        {
            var usuario = _servicioDeUsuario.obtenerUsuario(id);

            var respuesta = new Respuesta();
            respuesta.usuario = null;

            if (usuario == null)
            {
                respuesta.estatus = "Error";
                respuesta.detalle = "El usuario no existe";
            }
            else
            {
                if (contrasena == usuario.Contrasena)
                {
                    respuesta.estatus = "Todo bien";
                    respuesta.detalle = "Puedes iniciar sesion";
                    respuesta.usuario = usuario;
                }
                else
                {
                    respuesta.estatus = "Error";
                    respuesta.detalle = "Contraseña incorrecta ";
                }
            }

            return new JsonResult(respuesta);
        }

        /* registra los datos */

        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            var consulta = _servicioDeUsuario.obtenerUsuario(usuario.Correo);

            var respuesta = new Respuesta();

            if (consulta == null)
            {
                _servicioDeUsuario.RegistrarUsuario(usuario);

                respuesta.estatus = "Todo bien";
                respuesta.detalle = "El usuario se ha registrado";
            }
            else
            {
                respuesta.estatus = "Error";
                respuesta.detalle = "Este correo ya esta registrado";
            }

            return new JsonResult(respuesta);
        }

    }
}
