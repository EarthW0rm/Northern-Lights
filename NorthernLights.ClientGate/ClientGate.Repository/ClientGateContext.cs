using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientGate.Repository
{
    public class ClientGateContext : DbContext
    {
        public ClientGateContext(DbContextOptions<ClientGateContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Entities.AuthorizationCodesEntity> AuthorizationCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.AuthorizationCodesEntity>().ToTable("AuthorizationCodes", "dbo");
            base.OnModelCreating(modelBuilder);
        }

    }
}
