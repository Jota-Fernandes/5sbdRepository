using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using ModelAPI.Entities;

namespace ModelAPI.Context
{
    public class AeroportoContext : DbContext
    {
        public AeroportoContext(DbContextOptions<AeroportoContext> options) : base(options)
        {

        }

        public DbSet<Voo> Voo{get; set;}
    }
}