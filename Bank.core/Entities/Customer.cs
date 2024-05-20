namespace Bank.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int AppointmentId { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
