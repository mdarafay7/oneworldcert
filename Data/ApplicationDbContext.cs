using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using oneworldcert.Models;
using oneworldcert.Areas.Identity.Data;

namespace oneworldcert.Data
{
    public class ApplicationDbContext : IdentityDbContext<oneworldcertUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<oneworldcert.Models.Course> Course { get; set; }
        public DbSet<oneworldcert.Models.Candidate> Candidate { get; set; }
    }
}
