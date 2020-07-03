using Sibo.Examen.DAL.DAL;
using Sibo.Examen.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibo.Examen.BLL
{
    public class ProductBLL
    {
        public ProductBLL() { }

        public IEnumerable<Product> Get()
        {
            try
            {
                ProductDAL oProduct = new ProductDAL();
                return oProduct.Get();
            }
            catch (Exception Er)
            {
                throw new Exception("Ocurrio un error en la aplicacion", Er);
            }
        }

        public Product Post(Product product)
        {
            try
            {
                ProductDAL oProduct = new ProductDAL();
                return oProduct.Post(product);
            }
            catch (Exception Er)
            {
                throw new Exception("Ocurrio un error en la aplicacion", Er);
            }
        }

        public Product Update(Product product)
        {
            try
            {
                ProductDAL oProduct = new ProductDAL();
                return oProduct.Update(product);
            }
            catch (Exception Er)
            {
                throw new Exception("Ocurrio un error en la aplicacion", Er);
            }

        }
    }
}
