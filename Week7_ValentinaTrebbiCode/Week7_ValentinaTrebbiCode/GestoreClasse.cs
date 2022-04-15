using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7_ValentinaTrebbiCode.Entities;

namespace Week7_ValentinaTrebbiCode
{
    internal static class GestoreClasse
    {
        static List<Studente> studenti = new List<Studente>()
        {
            new Studente(2, "Jiji", "kkK", new DateTime(1997, 11, 2)),
            new Studente(3, "Rosa", "jj", new DateTime(1990, 10, 7)),
            new Studente(5, "Mario", "Rossi", new DateTime(1989, 5, 20)),
            new Studente(6, "Ron", "Ron", new DateTime(1995, 5, 10)),
            new Studente(7, "Harry", "Potter", new DateTime(1994, 6, 15)),
        };

        static List<Materia> materie = new List<Materia>()
        {
            new Materia(1, "matematica"),
            new Materia(2, "italiano"),
            new Materia(3, "biologia"),
            new Materia(4, "scienze"),
            new Materia(5, "chimica"),
        };

        public static bool RegistraInterrogazioneStudente()
        {
            bool done = false;
            Studente mioStudente = null;
            Materia miaMateria = null;
            Interrogazione interrogazione = new Interrogazione();

            foreach (Studente studente in studenti)
            {
                Console.WriteLine(studente.ToString());
            }

            Console.WriteLine("inserisci Id studente a cui assegnare l'interrogazione");
            int choice = LeggiNum();

            foreach (Studente studente in studenti)
            {
                if (choice == studente.Id)
                {
                    mioStudente = studente;
                }
            }

            if (mioStudente != null)
            {
                foreach (Materia materia in materie)
                {
                    Console.WriteLine(materia.ToString());
                }
                Console.WriteLine("inserisci id materia");
                choice = LeggiNum();

                foreach (var materia in materie)
                {
                    if (choice == materia.Id)
                    {
                        miaMateria = materia;
                    }
                }

                if (miaMateria != null)
                {
                    Console.WriteLine("inserisci la data dell'interrogazione nel formato YYYY/MM/DD");
                    DateTime data = LeggiData();
                    Console.WriteLine("inserisci un voto");
                    int voto = LeggiNum();

                    interrogazione.Materia = miaMateria;
                    interrogazione.Data = data;
                    interrogazione.Voto = voto;

                    if (mioStudente.Interrogazioni.Count > 0)
                    {

                        foreach (Interrogazione checkInterrogazione in mioStudente.Interrogazioni)
                        {
                            if (!(checkInterrogazione.Data == interrogazione.Data
                                && checkInterrogazione.Materia == interrogazione.Materia))
                            {

                                mioStudente.Interrogazioni.Add(interrogazione);
                                done = true;
                            }
                        }
                    }
                    else
                    {
                        mioStudente.Interrogazioni.Add(interrogazione);
                        done = true;
                    }

                }
            }

            return done;
        }

        static int LeggiNum()
        {
            int num = 0;

            while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
            {
                Console.WriteLine("numero non corretto o minore/uguale a 0");
            }

            return num;
        }

        static DateTime LeggiData()
        {
            DateTime data;

            while (!DateTime.TryParse(Console.ReadLine(), out data))
            {
                Console.WriteLine("formato non corretto");
            }

            return data;
        }

        public static void VisualizzaStudenti()
        {
            foreach (var studente in studenti)
            {
                Console.WriteLine(studente.ToString());
            }
        }

        public static void VisualizzaStudentiConInterrogazioni()
        {
            bool esiste = false;

            foreach (var studente in studenti)
            {
                if (studente.Interrogazioni.Count > 0)
                {
                    Console.WriteLine("STUDENTE:");
                    Console.WriteLine(studente.ToString());
                    Console.WriteLine("INTERROGAZIONI:");
                    foreach (var interrogazione in studente.Interrogazioni)
                    {
                        Console.WriteLine(interrogazione.ToString());
                    }
                    esiste = true;
                }
            }

            if (!esiste)
            {
                Console.WriteLine("mi dispiace ma non ci sono studenti con interrogazioni assegnate :(");
            }
        }

    }
}
