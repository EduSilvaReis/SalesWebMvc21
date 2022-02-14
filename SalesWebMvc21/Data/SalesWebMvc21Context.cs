﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc21.Models;

namespace SalesWebMvc21.Data
{
    public class SalesWebMvc21Context : DbContext
    {
        public SalesWebMvc21Context (DbContextOptions<SalesWebMvc21Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc21.Models.Department> Department { get; set; }
    }
}
