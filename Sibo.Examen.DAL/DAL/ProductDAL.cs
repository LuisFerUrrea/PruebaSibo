using Sibo.Examen.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibo.Examen.DAL.DAL
{
    public class ProductDAL
    {
        public ProductDAL()
        { }

        public IEnumerable<Product> Get()
        {
            var lProducts = new List<Product>();
            using (var dbCtx = new SiboSupermarketEntities())
            {
                dbCtx.Configuration.ProxyCreationEnabled = false;
                lProducts = dbCtx.Product.ToList();
            }
            return lProducts.AsEnumerable();
        }


        public Product Update(Product product)
        {
            using (var dbCtx = new SiboSupermarketEntities())
            {
                Product getProduct = dbCtx.Product.SingleOrDefault(b => b.ProductID == product.ProductID);
                if(getProduct!=null)
                {
                    dbCtx.Product.Attach(product);
                    dbCtx.Entry(product).State = EntityState.Modified;
                    int x = dbCtx.SaveChanges();
                    return ((x > 0) ? product : null);
                }
                return null;
            }
        }

        public Product Post(Product product)
        {
            using (var dbCtx = new SiboSupermarketEntities())
            {
                dbCtx.Configuration.ProxyCreationEnabled = false;
                dbCtx.Product.Add(product);
                int x = dbCtx.SaveChanges();
                return ((x > 0) ? product : null);
            }
        }

    }
}
