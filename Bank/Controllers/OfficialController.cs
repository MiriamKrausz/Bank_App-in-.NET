using AutoMapper;
using Bank.Core.DTOs;
using Bank.Core.Services;
using Bank.Entities;
using Bank.Models;
using Bank.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficialController : ControllerBase
    {
        private readonly IOfficialService _officialService;
        private readonly IMapper _mapper;
        public OfficialController(IOfficialService officialService, IMapper mapper)
        {
            _officialService = officialService;
            _mapper = mapper;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _officialService.GetOfficialsAsync();
            var listDto = _mapper.Map<IEnumerable<OfficialDto>>(list);
            return Ok(listDto);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var off = _officialService.GetOfficialByIdAsync(id);
            if (off is null)
            {
                return NotFound();
            }
            // var apponitmentDto=_mapper.Map<AppointmentDto>(app);
            return Ok(await off);
        }
        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] OfficialPostModel official)
        {
            var offToAdd = new Official { Name = official.Name, Addreess = official.Addreess, City = official.City, Age = official.Age, BranchNumber = official.BranchNumber, AppointmentId = official.AppointmentId };
            return Ok(await _officialService.AddOfficialAsync(offToAdd));
        }
        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Official official)
        {
            return Ok(await _officialService.UpdateOfficialAsync(id, official));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _officialService.DeleteOfficialAsync(id);
            return NoContent();
        }
    }
}
