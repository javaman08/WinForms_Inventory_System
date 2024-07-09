using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY_SYSTEM.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string BarCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public decimal ReOrderQuantity { get; set; }
        public decimal PackedWeight { get; set; }
        public decimal PackedWidth {  get; set; }
        public decimal PackedDepth { get; set; }
        public bool Refrigerated { get; set; }

    }
}
