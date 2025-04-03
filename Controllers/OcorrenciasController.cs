using Microsoft.AspNetCore.Mvc;
using SegurancaPublicaApi.Models;
using SegurancaPublicaApi.Services;
using SegurancaPublicaApi.ViewModels;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SegurancaPublicaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OcorrenciasController : ControllerBase
    {
        private readonly IOcorrenciaService _ocorrenciaService;

        public OcorrenciasController(IOcorrenciaService ocorrenciaService)
        {
            _ocorrenciaService = ocorrenciaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ocorrencias = await _ocorrenciaService.GetAllAsync();
            return Ok(ocorrencias);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var ocorrencia = await _ocorrenciaService.GetByIdAsync(id);
            if (ocorrencia == null)
                return NotFound(new { Message = "Ocorrência não encontrada." });

            return Ok(ocorrencia);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Ocorrencia ocorrencia)
        {
            await _ocorrenciaService.CreateAsync(ocorrencia);
            return CreatedAtAction(nameof(GetById), new { id = ocorrencia.Id }, ocorrencia);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] Ocorrencia ocorrencia)
        {
            await _ocorrenciaService.UpdateAsync(id, ocorrencia);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _ocorrenciaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
