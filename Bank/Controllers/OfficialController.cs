using AutoMapper;
using Bank.Core.DTOs;
using Bank.Core.Services;
using Bank.Entities;
using Bank.Models;
using Microsoft.AspNetCore.Mvc;


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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _officialService.GetOfficialsAsync();
            var listDto = _mapper.Map<IEnumerable<OfficialDto>>(list);
            return Ok(listDto);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var off = await _officialService.GetOfficialByIdAsync(id);
            if (off is null)
            {
                return NotFound();
            }
            var officialtDto = _mapper.Map<OfficialDto>(off);
            return Ok(officialtDto);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] OfficialPostModel official)
        {
            var offToAdd = new Official { Name = official.Name, Addreess = official.Addreess, City = official.City, Age = official.Age, BranchNumber = official.BranchNumber, AppointmentId = official.AppointmentId };
            await _officialService.AddOfficialAsync(offToAdd);
            return Ok(_mapper.Map<OfficialDto>(offToAdd));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Official official)
        {
            return Ok(await _officialService.UpdateOfficialAsync(id, official));
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _officialService.DeleteOfficialAsync(id);
            return NoContent();
        }
    }
}
