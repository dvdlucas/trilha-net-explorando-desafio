using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    internal class Pessoa
    {
        public Pessoa(string nome,string sobrenome) 
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}
