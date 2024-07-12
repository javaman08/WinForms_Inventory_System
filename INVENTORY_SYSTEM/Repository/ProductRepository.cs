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

        public void AddProduct(Product request)
        {
            using (var conn = new SqlConnection(AppConnection.ConnectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[Product] 
                            ([ProductCode], [BarCode], [ProductName], [ProductDescription], [ProductCategory], [ReorderQuantity], [PackedWeight], [PackedWidth], [PackedDepth], [Refrigerated]) 
                            VALUES (@ProductCode, @BarCode, @ProductName, 
                                    @ProductDescription, @ProductCategory, 
                                    @ReorderQuantity, @PackedWeight, @PackedWidth, 
                                    @PackedDepth, @Refrigerated)";

                    cmd.Parameters.AddWithValue("@ProductCode", request.ProductCode);
                    cmd.Parameters.AddWithValue("@BarCode", request.BarCode);
                    cmd.Parameters.AddWithValue("@ProductName", request.ProductName);
                    cmd.Parameters.AddWithValue("@ProductDescription", request.ProductDescription);
                    cmd.Parameters.AddWithValue("@ProductCategory", request.ProductCategory);
                    cmd.Parameters.AddWithValue("@ReorderQuantity", request.ReOrderQuantity);
                    cmd.Parameters.AddWithValue("@PackedWeight", request.PackedWeight);
                    cmd.Parameters.AddWithValue("@PackedWidth", request.PackedWidth);
                    cmd.Parameters.AddWithValue("@PackedDepth", request.PackedDepth);
                    cmd.Parameters.AddWithValue("@Refrigerated", request.Refrigerated);

                    var result = cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
