using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Brand
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string About { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
