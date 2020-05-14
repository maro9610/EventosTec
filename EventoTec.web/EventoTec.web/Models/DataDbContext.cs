using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventoTec.web.Models.entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventoTec.web.Models
{
    public class DataDbContext :IdentityDbContext<User>
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet <Manager>Managers { get; set; }
        


    }
}
