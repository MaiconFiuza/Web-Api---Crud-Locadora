using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Locadora.Models;
using Microsoft.EntityFrameworkCore;

namespace Locadora.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }


    }
}
