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
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IMapper _mapper;

        public AppointmentController(IAppointmentService appointmentService, IMapper mapper)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _appointmentService.GetAppointmentsAsync();
            var listDto = _mapper.Map<List<AppointmentDto>>(list);
            return Ok(listDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var app = await _appointmentService.GetByIdAsync(id);
            if (app is null)
            {
                return NotFound();
            }
            var apponitmentDto = _mapper.Map<AppointmentDto>(app);
            return Ok(apponitmentDto);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AppointmentPostModel appointment)
        {
            var appToAdd = new Appointment { Date = appointment.Date, CustomerId = appointment.CustomerId, OfficialId = appointment.OfficialId };
            await _appointmentService.AddAppointmentAsync(appToAdd);
            return Ok(_mapper.Map<AppointmentDto>(appToAdd));
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Appointment appointment)
        {
            return Ok(await _appointmentService.UpdateAppointmentAsync(id, appointment));
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _appointmentService.DeleteAppointmentAsync(id);
            return NoContent();
        }
    }
}
