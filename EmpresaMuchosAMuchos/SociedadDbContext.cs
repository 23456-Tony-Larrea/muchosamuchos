using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaMuchosAMuchos
{
    class SociedadDbContext:DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            modelBuilder.Entity<EmpresaClientes>()
                .HasKey(ea => new { ea.ClientesId, ea.EmpresaId });
           
            modelBuilder.Entity<EmpresaClientes>()
               .HasOne(ea=>ea.Empresa)
               .WithMany(a => a.EmpresaClientes)
               .HasForeignKey(p => p.EmpresaId);

            modelBuilder.Entity<EmpresaClientes>()
            .HasOne(ea => ea.Clientes)
            .WithMany(a => a.EmpresaClientes)
            .HasForeignKey(p => p.ClientesId);

        }
    }
}
