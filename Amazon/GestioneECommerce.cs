using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    internal static class GestioneECommerce
    {
        public static List<Prodotto> prodotti = new List<Prodotto>()
        {
            new Prodotto("P1", "Fazzoletti", 1, 0),
            new Prodotto("P2", "Penna", 10, 50) //prodotto con sconto del 50 %
        };
    

        public static List<Utente> utenti = new List<Utente>()
        {
            new Utente(){Nome="Mario", Cognome="Rossi", Username="mrossi", Password="1234"}
        };

        public static Utente IsAutenticato(string user, string password)
        {
            foreach (var item in utenti)
            {
                if (item.Username == user && item.Password == password)
                {
                    item.StampaUtente();
                    return item;
                }
            }
            return null;
        }

        public static Prodotto CercaProdottoPerCodice(string codice)
        {
            foreach (var item in prodotti)
            {
                if (item.Codice == codice)
                {
                    Console.WriteLine(item.GetInfo());
                    return item;
                }
            }
            return null;
        }

        public static DettaglioOrdine CercaDettaglioPerCodiceProdotto(string codice, Carrello carrello)
        {
            foreach (var item in carrello.DettagliOrdine)
            {
                if (item.Prodotto.Codice == codice)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
