// See https://aka.ms/new-console-template for more information
using Week7_ValentinaTrebbiCode;
using Week7_ValentinaTrebbiCode.Entities;

Console.WriteLine("-----Benvenuto-----");

bool program = true;
int choice = 0;

//L’applicazione permette all’insegnante di inserire una votazione a sistema indicando lo studente, la materia e
//il giorno della prova/interrogazione.


do
{
    Menu();
    choice = LeggiNum();

    switch (choice)
    {
        case 1:
            if (GestoreClasse.RegistraInterrogazioneStudente())
            {
                Console.WriteLine("l'operazione è andata a buon fine");
            }
            else
            {
                Console.WriteLine("qualcosa è andato storto, potresti aver inserito gia questa interrogazione oppure i dati non sono corretti," +
                    " verifica di aver inserito correttamente i dati richiesti");
            };
            break;

        case 2:
            GestoreClasse.VisualizzaStudenti();
            break;

        case 3:
            GestoreClasse.VisualizzaStudentiConInterrogazioni();
            break;

        case 4:
            program = false;
            break;

        default:
            Console.WriteLine("scelta non valida");
            break;
    }

} while (program);


static int LeggiNum()
{
    int num = 0;

    while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
    {
        Console.WriteLine("numero non corretto o minore/uguale a 0");
    }

    return num;
}

static void Menu()
{
    Console.WriteLine("1- registra interrogazione studente");
    //Console.WriteLine("2- registra studente");
    Console.WriteLine("2- visualizza studenti");
    Console.WriteLine("3- visualizza studenti con le rispettive interrogazioni");
    Console.WriteLine("4- esci");
}
