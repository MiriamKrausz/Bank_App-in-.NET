using Bank.Core.Repositories;
using Bank.Entities;
using Microsoft.EntityFrameworkCore;


namespace Bank.Data.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly DataContext _context;


        public AppointmentRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public async Task<List<Appointment>> GetAppointmentsAsync()
        {
            return await _context.AppointmentList.Include(u => u.Customer).Include(u => u.Official).ToListAsync();
        }
        public async Task<Appointment> GetByIdAsync(int id)
        {
            return _context.AppointmentList.Find(id);
        }
        public async Task<Appointment> AddAppointmentAsync(Appointment appointment)
        {
            _context.AppointmentList.Add(appointment);
            await _context.SaveChangesAsync();
            return appointment;
        }
        public async Task<Appointment> UpdateAppointmentAsync(int id, Appointment appointment)
        {
            var updatedAppointment = _context.AppointmentList.Find(id);
            updatedAppointment = appointment;
            await _context.SaveChangesAsync();
            return updatedAppointment;
        }
        public async Task DeleteAppointmentAsync(int id)
        {
            _context.AppointmentList.Remove(_context.AppointmentList.Find(id));
            await _context.SaveChangesAsync();
        }
    }
}
