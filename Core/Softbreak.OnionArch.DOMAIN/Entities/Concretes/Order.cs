using Softbreak.OnionArch.DOMAIN.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.DOMAIN.Entities.Concretes
{
    public class Order : BaseEntity
    {
        public string ShippedAddress { get; set; }
        public int? AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
