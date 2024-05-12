using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesBll.Dtos
{
    public class BasketDto
    {
        public int Id { get; set; }
        private int _quantity = 1; // Default value is 1

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value < 1 ? 1 : value; } // Ensure quantity is never less than 1
        }
    }
}
