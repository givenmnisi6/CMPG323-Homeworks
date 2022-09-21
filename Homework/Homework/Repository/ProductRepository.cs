using Homework.Data;
using Homework.Models;
using System.Collections.Generic;
using System.Linq;

namespace Homework.Repository
{
    public class ProductRepository
    {
        protected readonly ProductDBContext _context = new ProductDBContext();
        // GET ALL: Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Product.ToList();
        }

    }
}
