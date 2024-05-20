
using Bank.Core.Repositories;
using Bank.Core.Services;
using Bank.Entities;

namespace Bank.Service
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _iAppointmentRepository;
        public AppointmentService(IAppointmentRepository iAppointmentRepository)
        {
            _iAppointmentRepository = iAppointmentRepository;
        }
        public async Task<List<Appointment>> GetAppointmentsAsync()
        {
            return await _iAppointmentRepository.GetAppointmentsAsync();
        }
        public async Task<Appointment> GetByIdAsync(int id)
        {
            return await _iAppointmentRepository.GetByIdAsync(id);
        }

        public async Task<Appointment> AddAppointmentAsync(Appointment appointment)
        {
            return await _iAppointmentRepository.AddAppointmentAsync(appointment);
        }
        public async Task<Appointment> UpdateAppointmentAsync(int id, Appointment appointment)
        {
            return await _iAppointmentRepository.UpdateAppointmentAsync(id, appointment);
        }
        public async Task DeleteAppointmentAsync(int id)
        {
            await _iAppointmentRepository.DeleteAppointmentAsync(id);
        }
    }
}
