using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Order
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public  int ProductId { get; set; }
        public List<Product> products { get; set; }
        public int CustumerId { get; set; }
        public Custumer Custumer { get; set; }
        public int EmployeeId{ get; set; }
        public Employee Employee { get; set; }
        public DateTime OrderCreatedDate { get; set; }
    }
}
