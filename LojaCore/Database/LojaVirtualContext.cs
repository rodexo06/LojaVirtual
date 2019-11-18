using LojaCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaCore.Database
{
    public class LojaCoreContext : DbContext
    {
        /*
         * EF Core - ORM
         * ORM -> Bibliteca mapear Objetos para Banco de Dados Relacionais
         */
        public LojaCoreContext(DbContextOptions<LojaCoreContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<NewsletterEmail> NewsletterEmails { get; set; }

    }
}
