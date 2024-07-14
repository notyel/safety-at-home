﻿using Microsoft.EntityFrameworkCore;
using SafetyAtHome.Domain.Entities.Auth;

namespace SafetyAtHome.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}