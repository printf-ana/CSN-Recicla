using CSNRecicla.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSNRecicla.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {
        public DbSet<Embalagem> Embalagems { get; set; }
        public DbSet<PontoDeColeta> PontoDeColetas { get; set; }
        public DbSet<HorarioFuncionamento> HorarioFuncionamentos { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
