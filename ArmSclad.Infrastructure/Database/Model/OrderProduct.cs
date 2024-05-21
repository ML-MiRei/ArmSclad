using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmSclad.Infrastructure.Database.Model
{
    public class OrderProduct
    {   
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public double Amount { get; set; }
    }
}
