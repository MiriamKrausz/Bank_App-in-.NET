using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int AppointmentId { get; set; }
    }
}
