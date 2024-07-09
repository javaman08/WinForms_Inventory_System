using INVENTORY_SYSTEM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace INVENTORY_SYSTEM.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>();

            using (var conn = new SqlConnection(AppConnection.ConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT * FROM PRODUCT";

                    var result = cmd.ExecuteReader();

                    while(result.Read())
                    {
                        products.Add(new Product()
                        {
                            Id = Convert.ToInt32(result["PRODUCTID"]),
                            ProductCode = Convert.ToString(result["PRODUCTCODE"]),
                            BarCode = Convert.ToString(result["BARCODE"]),
                            ProductName = Convert.ToString(result["PRODUCTNAME"]),
                            ProductDescription = Convert.ToString(result["PRODUCTDESCRIPTION"]),
                            ProductCategory = Convert.ToString(result["PRODUCTCATEGORY"]),
                            ReOrderQuantity = Convert.ToDecimal(result["REORDERQUANTITY"]),
                            PackedWeight = Convert.ToDecimal(result["PACKEDWEIGHT"]),
                            PackedWidth = Convert.ToDecimal(result["PACKEDWIDTH"]),
                            PackedDepth = Convert.ToDecimal(result["PACKEDDEPTH"]),
                            Refrigerated = Convert.ToBoolean(result["REFRIGERATED"])
                        });
                    }

                }
            }

            return products;
        }

        public Product AddProduct(Product request)
        {
            throw new NotImplementedException();
        }
    }
}
