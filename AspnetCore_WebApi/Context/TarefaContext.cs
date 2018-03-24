using AspnetCore_WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_WebApi.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options)
            : base(options)

        {

        }

        public DbSet<TarefaItem> TarefaItens { get; set; }
    }
}
