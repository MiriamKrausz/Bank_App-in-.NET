namespace Bank.Models
{
    public class CustomerPostModel
    {
        public int PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

       public int AppointmentId { get; set; }
    }
}
