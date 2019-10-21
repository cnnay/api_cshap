using System.Collections.Generic;
using System.Linq;
using Aula2_API.Context;
using Aula2_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula2_API.Controllers  
{
    [ApiController]
    [Route("v1/[controller]")]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        Aula2Context Context = new Aula2Context();
        
        [HttpGet]

        public IActionResult listar()
        {
            List<UsuarioModel> listaDeUsuarios = Context.tbl_usuario.ToList();

            return Ok(listaDeUsuarios);
        }
        [HttpPost("usuario")]

        public IActionResult Cadastrar(UsuarioModel usuario)
        {
            Context.tbl_usuario.Add(usuario);
            Context.SaveChanges();
            return Ok();
        }
            [HttpGet("{id}")]

            public IActionResult BuscarPorId(int id)
        {
            UsuarioModel usuarioRetornado = Context.tbl_usuario.FirstOrDefault(x => x.usuario_id == id);

            return Ok(usuarioRetornado);
        }
    }
}