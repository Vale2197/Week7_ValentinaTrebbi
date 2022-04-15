using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_ValentinaTrebbiCode.Entities
{
    internal class Interrogazione
    {
        public int Id { get; set; }

        public Studente Studente { get; set; } = new Studente();
        public Materia Materia { get; set; } = new Materia();

        public DateTime Data { get; set; } = new DateTime();

        public int Voto { get; set; }

        public Interrogazione()
        {

        }

        public Interrogazione(int id, Studente studente, Materia materia, DateTime data, int voto)
        {
            Id = id;
            Studente = studente;
            Materia = materia;
            Data = data;
            Voto = voto;
        }

        public override string ToString()
        {
            return $"Data: {Data.Day}/{Data.Month}/{Data.Year} - Voto: {Voto} - Materia: {Materia.Nome}";
        }
    }
}
