using System;
using Microsoft.EntityFrameworkCore;
using TesteAPI.Models;

namespace TesteAPI.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos {get; set;}
    }
}