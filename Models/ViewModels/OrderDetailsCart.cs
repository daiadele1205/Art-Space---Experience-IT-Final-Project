using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtSpace_Project.Models.ViewModels
{
    public class OrderDetailsCart
    {
        public List<ShoppingCart> ListCart { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
