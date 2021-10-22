using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using hostal.Models;


namespace hostal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
             public DbSet<hostal.Models.Product> DataProducts { get; set; }

             public DbSet<hostal.Models.Contact> DataContactos { get; set; }

        }



    }

