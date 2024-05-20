using Bank.Entities;


namespace Bank.Core.Repositories
{
    public interface IAppointmentRepository
    {
        Task<List<Appointment>> GetAppointmentsAsync();

        Task<Appointment> GetByIdAsync(int id);
        Task<Appointment> AddAppointmentAsync(Appointment appointment);
        Task<Appointment> UpdateAppointmentAsync(int id, Appointment appointment);
        Task DeleteAppointmentAsync(int id);
    }
}
