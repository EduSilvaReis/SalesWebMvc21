using SalesWebMvc21.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc21.Models;

namespace SalesWebMvc21.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc21Context _context;

        public DepartmentService(SalesWebMvc21Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
