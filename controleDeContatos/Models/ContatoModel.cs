using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleDeContatos.Models
{
    public class ContatoModel
    {
        // Colunas do banco de dados
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Cel {get; set;}

    }
}