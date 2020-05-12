using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventoTec.web.Models.entities;
using Microsoft.EntityFrameworkCore;

namespace EventoTec.web.Models
{
    public class DataDbContext :DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<City> City { get; set; }

    }
}
