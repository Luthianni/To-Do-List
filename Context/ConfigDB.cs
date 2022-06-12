using Microsoft.EntityFrameworkCore;
using PraHoje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraHoje.Context
{
    public class ConfigDB : DbContext
    {
        public ConfigDB(DbContextOptions<ConfigDB> options) : base(options)
        { }

        public DbSet<TarefasListaVM> TarefasListas { get; set; }
    }
}
