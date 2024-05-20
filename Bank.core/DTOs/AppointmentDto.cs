
namespace Bank.Core.DTOs
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public int OfficialId { get; set; }
    }
}
