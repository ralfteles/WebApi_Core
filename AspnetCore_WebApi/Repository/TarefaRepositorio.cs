using AspnetCore_WebApi.Context;
using AspnetCore_WebApi.Contract;
using AspnetCore_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_WebApi.Repository
{
        public class TarefaRepositorio : ITarefaRepositorio
        {
            private readonly TarefaContext _context;

            public TarefaRepositorio(TarefaContext context)            
            {
                _context = context;
            }

            public IEnumerable<TarefaItem> GetAll()
            {
                return _context.TarefaItens.ToList();
            }

            public void Add(TarefaItem item)
            {
                _context.TarefaItens.Add(item);
                _context.SaveChanges();
            }

            public TarefaItem Find(long key)
            {
                return _context.TarefaItens.FirstOrDefault(t => t.Chave == key);
            }

            public void Remove(long key)
            {
                var entity = _context.TarefaItens.First(t => t.Chave == key);
                _context.TarefaItens.Remove(entity);
                _context.SaveChanges();
            }

            public void Update(TarefaItem item)
            {
                _context.TarefaItens.Update(item);
                _context.SaveChanges();
            }
        }
}
