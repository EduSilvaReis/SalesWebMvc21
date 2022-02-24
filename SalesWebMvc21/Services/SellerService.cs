using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc21.Models;
using SalesWebMvc21.Data;

namespace SalesWebMvc21.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc21Context _context;

        public SellerService(SalesWebMvc21Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
