using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SistemaVenta.BLL.Servicios.Contrato;
using SistemaVenta.DTO;
using SistemaVenta.api.Utilidad;

namespace SistemaVenta.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var rsp = new Response<List<UsuarioDTO>>();

            try
            {
                rsp.Status = true;
                rsp.Value = await _usuarioService.Lista();
            }
            catch (Exception ex)
            {
                rsp.Status = false;
                rsp.Message = ex.Message;

            }
            return Ok(rsp);
        }

        [HttpPost]
        [Route("IniciarSesion")]
        public async Task<IActionResult> IniciarSesion([FromBody]LoginDTO login)
        {
            var rsp = new Response<SesionDTO>();

            try
            {
                rsp.Status = true;
                rsp.Value = await _usuarioService.ValidarCredenciales(login.Email, login.Clave);
            }
            catch (Exception ex)
            {
                rsp.Status = false;
                rsp.Message = ex.Message;

            }
            return Ok(rsp);
        }

        [HttpPost]
        [Route("Guardar")]
        public async Task<IActionResult> Guardar([FromBody]UsuarioDTO usuario)
        {
            var rsp = new Response<UsuarioDTO>();

            try
            {
                rsp.Status = true;
                rsp.Value = await _usuarioService.Crear(usuario);
            }
            catch (Exception ex)
            {
                rsp.Status = false;
                rsp.Message = ex.Message;

            }
            return Ok(rsp);
        }

        [HttpPut]
        [Route("Editar")]
        public async Task<IActionResult> Editar([FromBody]UsuarioDTO usuario)
        {
            var rsp = new Response<bool>();

            try
            {
                rsp.Status = true;
                rsp.Value = await _usuarioService.Editar(usuario);
            }
            catch (Exception ex)
            {
                rsp.Status = false;
                rsp.Message = ex.Message;

            }
            return Ok(rsp);
        }

        [HttpDelete]
        [Route("Eliminar/{id:int}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var rsp = new Response<bool>();

            try
            {
                rsp.Status = true;
                rsp.Value = await _usuarioService.Eliminar(id);
            }
            catch (Exception ex)
            {
                rsp.Status = false;
                rsp.Message = ex.Message;

            }
            return Ok(rsp);
        }

    }
}
