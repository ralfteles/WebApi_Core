using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore_WebApi.Models
{
    public class TarefaItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Chave { get; set; }
        public string Nome { get; set; }
        public bool EstaComplata { get; set; }
    }
}
