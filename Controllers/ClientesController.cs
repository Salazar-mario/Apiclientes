using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apiclientes.modelos;
using Apiclientes.Repositorio;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace Apiclientes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            RepoClientes rpCli = new RepoClientes();
            return Ok(rpCli.ObtenerClientes());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RepoClientes rpCli = new RepoClientes();

            var cliRet = rpCli.ObtenerCliente(id);

            if (cliRet == null)
            {
                var nf = NotFound("El cliente " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(cliRet);
        }

        [HttpPost("agregar")]
        public IActionResult AgregarCliente(Clientes nuevoCliente)
        {
            RepoClientes rpCli = new RepoClientes();
            rpCli.Agregar(nuevoCliente);
            return CreatedAtAction(nameof(AgregarCliente), nuevoCliente);
        }
    }
}