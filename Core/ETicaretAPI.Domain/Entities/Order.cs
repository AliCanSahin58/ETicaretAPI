using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; } // bu  bir order ın birden fazla productı nın oldğunu ifade ediyor.

        public Customer Customer { get; set; } // bir orderın birden fazla customer ı olamaz bu yüzden n e 1 ilişki vardır.

    }
}
