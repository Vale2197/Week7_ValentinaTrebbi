// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
//1.Dimostrare come gestire un’eccezione data dalla mancata connessione a un database.
//2. Creare una Eccezione personalizzata (custom Exception) relativa a un utente non trovato. Dimostrarne l’utilizzo.

//     1)
//     try
//     {
//         string connectionString = "stringa";
//         SqlConnection conn = new SqlConnection(connectionString);
//     }
//     catch (ArgumentException ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
//     catch (SqlException ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine(ex.Message);
//     }


//    2) 
//    public class UserNotFoundEx : Exception
//    {
//        public UserNotFoundEx(string message) : base(message)
//        {

//        }
//    };

//
//    bool found = false;
//    Studente studente = null;
//    int idToSearch = 1;

//    foreach (var item in studenti)
//    {
//        if (item.id == idToSearch)
//        {
//            found = true;
//            studente = item;
//        }
//    }

//    if (!found)
//    {
//        throw new UserNotFoundEx("utente non trovato");
//    }
//


