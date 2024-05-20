
namespace Bank.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public int OfficialId { get; set; }

        public Customer Customer { get; set; }
        public Official Official { get; set; }
    }
}
