using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCore.DB
{
    public class NETCoreDBContext : DbContext
    {
        public NETCoreDBContext(DbContextOptions<NETCoreDBContext> options)
            : base(options)
        {

        }

        public DbSet<product> product { get; set; }

    }
}
