using Application.Transferencia.Services;
using Domain.Transferencia.Commands;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TransferenciaNFC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferenciaController : ControllerBase
    {
        private readonly IEnvioTransferenciaService _service;
        public TransferenciaController(IEnvioTransferenciaService service)
        {
            _service = service;
        }

        [HttpPost("enviar")]
        public IActionResult Enviar(EnvioCommand command)
        {
            return this.Ok(_service.Enviar(command));
        }

        [HttpGet("receber")]
        public IActionResult Receber(Guid dispositivoId)
        {
            return this.Ok(_service.Receber(dispositivoId));
        }
    }
}