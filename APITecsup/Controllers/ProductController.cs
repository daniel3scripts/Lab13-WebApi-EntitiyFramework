using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Service;
using Domain;
using System.Threading.Tasks;

namespace APITecsup.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public List<Producto> GetProducts()
        {
            var service = new ProductService();
            var products = service.GetProducts();

            return products;
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        //public void Post([FromBody]string value)
        //{

        //}
        //public async Task<Producto> InsertCalculo(Producto factura)
        //{
            
        //    factura.IGV = factura.SalePrice * 0.18M;
            
        //    var service = new ProductService();
        //    service.InsertProducts( factura);
        //    //await Where(x => x.IsActive= true).ToList();
                
        //    return factura;
        //}



        [HttpPost]
        public bool InsertProducts(Producto producto)
        {
            var respo = true;
            try
            {
                var service = new ProductService();
                service.InsertProducts(new Producto
                {
                    Name = producto.Name,
                    Description = producto.Description,
                    SalePrice = producto.SalePrice,
                    IGV= producto.IGV,
                    ExpiryDate =producto.ExpiryDate
                    

            });   
            }
            catch (Exception )
            {

                respo = false;
                //throw e;
            }
            return respo;
        }

        

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
