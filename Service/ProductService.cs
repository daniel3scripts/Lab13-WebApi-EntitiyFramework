using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infraestructure;

namespace Service
{
    public class ProductService
    {
        public List<Producto> GetProducts()
        
        {
            using (var contextito = new ExampleContext())
            {
                return contextito.Productos.Where(z => z.IsActive == true).ToList();
            }
                //return new List<Producto>(); 
        }
        public Producto GetProductsById(int id)
        {
            using(var contextito = new ExampleContext())
            {
                return contextito.Productos.Find(id);
            }
        }

        public void InsertProducts(Producto producto)
        {
            using( var contextito = new ExampleContext())
            {
                producto.IsActive = true;
                producto.CreationDate = DateTime.Now;
                //producto.ExpiryDate = DateTime.Today;
                producto.IGV = producto.SalePrice * 0.18M;
                contextito.Productos.Add(producto);
                contextito.SaveChanges();
            }
        }
         
    }
}
