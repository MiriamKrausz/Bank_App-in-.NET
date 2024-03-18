namespace Bank.Entities
{
    public class Official
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addreess { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public int BranchNumber { get; set; }

        public int AppointmentId { get; set; }
        public List<Appointment> Appointments { get; set; }

        //public Official(int id, string name, string addreess, string city, int age, int branchNumber)
        //{
        //    Id = id;
        //    Name = name;
        //    Addreess = addreess;
        //    City = city;
        //    Age = age;
        //    BranchNumber = branchNumber;
        //}
    }
}
