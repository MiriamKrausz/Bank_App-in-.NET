using AutoMapper;
using Bank.Core.DTOs;
using Bank.Core.Services;
using Bank.Entities;
using Bank.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IMapper _mapper;

        public AppointmentController(IAppointmentService appointmentService,IMapper mapper)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async  Task<IActionResult> Get()
        {
            var list =await  _appointmentService.GetAppointmentsAsync();
            var listDto = _mapper.Map<List<AppointmentDto>>(list);
            return Ok(listDto);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var app = _appointmentService.GetByIdAsync(id);
            if (app is null)
            {
                return NotFound();
            }
           // var apponitmentDto=_mapper.Map<AppointmentDto>(app);
            return Ok(await app);
        }
        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AppointmentPostModel appointment)
        {
            var appToAdd = new Appointment { Date = appointment.Date, CustomerId = appointment.CustomerId, OfficialId = appointment.OfficialId };
            return Ok(await _appointmentService.AddAppointmentAsync(appToAdd));
        }
        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Appointment appointment)
        {
            return Ok(await _appointmentService.UpdateAppointmentAsync(id,appointment));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _appointmentService.DeleteAppointmentAsync(id);
            return NoContent();
        }
    }
}
