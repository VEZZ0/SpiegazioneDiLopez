using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpiegazioneDiLopez.Models;
using SpiegazioneDiLopez.Models.Dto;
using System.Collections.Generic;
using System.Linq;

namespace SpiegazioneDiLopez.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        [HttpGet("GetScaffale", Name = "GetScaffale")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<LibroDTO>> GetLibri()
        {
            var listaLibri = Scaffale.getListaLibri();
            if (listaLibri == null || !listaLibri.Any())
            {
                return NoContent();
            }

            return Ok(listaLibri);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<LibroDTO> CreateLibro([FromBody] LibroDTO librodto)
        {
            if (librodto == null)
            {
                return BadRequest();
            }

            Scaffale.listaLibri.Add(librodto);

            return CreatedAtAction(nameof(GetLibri), new { }, librodto);
        }
    }
}
