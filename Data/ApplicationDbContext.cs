using ArtSpace_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtSpace_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Medium> Medium { get; set; }
        public DbSet<ArtworkType> ArtworkType { get; set; }
        public DbSet<ArtworkPortfolio> ArtworkPortfolio { get; set; }
        public DbSet<Coupon> Coupon { get; set; }
    }
}
