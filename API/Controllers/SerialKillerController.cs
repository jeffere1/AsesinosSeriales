using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Entidades;
using Infraestructura.Datos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SerialKillerController : ControllerBase
    {
        private readonly ApplicationDBContext _dBContext;

        public SerialKillerController(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        //Debo agregar un id para diferenciar mas de un metodo get
        [HttpGet]
        public async Task<ActionResult<List<SerialKiller>>> ListarAsesinosSeriales(){

            List<SerialKiller> asesinosSeriales = await _dBContext.SerialKiller.ToListAsync();

            return Ok(asesinosSeriales);
        }

        [HttpGet("{id}")]
        public async Task<SerialKiller> GetSerialKiller(int id){
            SerialKiller asesinoSerial = await _dBContext.SerialKiller.FindAsync(id);
            return asesinoSerial;
        }

    }
}