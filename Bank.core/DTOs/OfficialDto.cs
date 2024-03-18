using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.DTOs
{
    public class OfficialDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addreess { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public int BranchNumber { get; set; }
        public int AppointmentId { get; set; }
    }
}
