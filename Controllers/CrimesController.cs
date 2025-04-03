using Microsoft.AspNetCore.Mvc;
using SegurancaPublicaApi.Models;
using SegurancaPublicaApi.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SegurancaPublicaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CrimesController : ControllerBase
{
    private readonly ICrimeService _crimeService;

    public CrimesController(ICrimeService crimeService)
    {
        _crimeService = crimeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCrimes()
    {
        var crimes = await _crimeService.GetAllAsync();
        return Ok(crimes);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCrime([FromBody] Crime crime)
    {
        await _crimeService.CreateAsync(crime);
        return CreatedAtAction(nameof(GetAllCrimes), new { id = crime.Id }, crime);
    }
}
