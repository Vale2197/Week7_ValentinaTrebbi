using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_ValentinaTrebbiCode.Entities
{
    internal class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Materia()
        {

        }

        public Materia(int id, string nome)
        {
            Nome = nome;
            Id = id;
        }

        public override string ToString()
        {
            return $"ID: {Id} - Nome: {Nome}";
        }
    }
}
