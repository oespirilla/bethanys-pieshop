using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using BethanyPieShop.Models;

namespace BethanyPieShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart {get; set; }
        public decimal ShoppingCartTotal {get; set; }

    }

}