using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace POS.Server.Services
{
    [DataContract]
    public class Item
    {
        [DataMember(Name = "ItemId")]
        public int ItemId { get; set; }

        [DataMember(Name = "ItemName")]
        public string ItemName { get; set; }

        [DataMember(Name = "Price")]
        public double Price { get; set; }

        [DataMember(Name = "Quantity")]
        public int Quantity { get; set; }
    }
}
