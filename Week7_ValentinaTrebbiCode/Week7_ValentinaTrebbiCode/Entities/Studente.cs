using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_ValentinaTrebbiCode.Entities
{
    internal class Studente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; } = new DateTime();

        public List<Interrogazione> Interrogazioni { get; set; } = new List<Interrogazione>();

        public Studente()
        {

        }

        public Studente(int id, string nome, string cognome, DateTime dataN)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataN;
        }

        public override string ToString()
        {
            return $"ID: {Id} - Nome: {Nome} - Cognome: {Cognome} - DataNascita: {DataNascita.Day}/{DataNascita.Month}/{DataNascita.Year}";
        }
    }
}
