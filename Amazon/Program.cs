// See https://aka.ms/new-console-template for more information
using Amazon;

Console.WriteLine("Hello, World!");
/*
Progettare la struttura ad oggetti per gestire un carrello di un sito di e-commerce. 
Il sito ha degli utenti iscritti. (Inserire almeno già un utente iscritto).
L’utente è caratterizzato da Username, Password, Nome e Cognome. 
Un carrello è associato all’utente collegato al sito, e per ogni utente è previsto un solo carrello 
con il riepilogo degli ordini/dettagli desiderati e del prezzo totale da pagare.
(nota: è importante risalire dall’utente al carrello e non il viceversa).
Ogni prodotto che il sito mette in vendita è caratterizzato da un codice, una descrizione, un prezzo, una percentuale di sconto (opzionale).
(Nota: creare un elenco di prodotti che il sito metterà a disposizione. Almeno 2.) 
Ogni carrello può contenere diversi ordini; ogni Dettaglio è costituito dalle seguenti informazioni:
prodotto, la quantità, il prezzo totale (rispetto alla quantità e al prezzo “pieno” del prodotto), il prezzo totale scontato (calcolato rispetto alla percentuale di sconto del singolo prodotto). 

All’accesso, viene chiesta username e password. Se sono corrette si procede a far visualizzare il menu, altrimenti si chiede all’utente se vuole registrarsi quindi si richiedono i dati necessari alla registrazione e si aggiunge l’utente agli utenti iscritti al sito. 
Completata la registrazione, l’utente resta quindi “loggato” e accede al menu.

1.	Aggiungi prodotto al carrello*
2.	Elimina prodotto
3.	Modifica quantità di un prodotto già inserito
4.	Stampa a video riepilogo del carrello (formato a piacere. Deve contenere i dati dell’utente “loggato” e 
    il Totale da pagare in base agli ordini/dettagli presenti nel carrello)
0.	Esci
*Si noti che nel caso sia inserito un prodotto che già esiste nel carrello questo va a modificare la quantità del prodotto precedentemente inserito.

 */


var listaProdotti = GestioneECommerce.prodotti;

Console.WriteLine("Hello World!");
Console.WriteLine("Inserisci Username: ");
string username = Console.ReadLine();
Console.WriteLine("Inserisci Password: ");
string password = Console.ReadLine();

//Verifico se è presente nella mia lista di "utenti iscritti al sito"
Utente user = new Utente();
user = GestioneECommerce.IsAutenticato(username, password);

if (user == null)
{
    Console.WriteLine("\nNon sei registrato. Vuoi registrarti? SI/NO");
    string risposta = Console.ReadLine();
    if (risposta.ToUpper() == "SI")
    {
        Console.Write("\nCompleta la registrazione. \nInserisci Nome: ");
        string nome = Console.ReadLine();
        Console.Write("\nInserisci Cognome: ");
        string cognome = Console.ReadLine();
        Console.Write("\nInserisci Username: ");
        string newUsername = Console.ReadLine();
        Console.Write("\nInserisci Password: ");
        string newPassword = Console.ReadLine();
        //Ho tutte le info necessarie per creare un utente
        Utente u = new Utente(nome, cognome, newUsername, newPassword);
        //Devo aggiungerlo alla lista degli utenti del sito.
        GestioneECommerce.utenti.Add(u);
        Console.WriteLine("Complimenti! Ti sei iscritto");
        user = u; //"utente loggato"
    }
    else
    {
        Console.WriteLine("Ciao!");
        return;
    }
}
else
{
    Console.WriteLine("Accesso effettuato");
}

do
{
    Console.WriteLine("\n---------------------Menu--------------------");
    Console.WriteLine("Premi 1 - Aggiungere prodotto/Dettaglio");
    Console.WriteLine("Premi 2 - Elimina prodotto/Dettaglio");
    Console.WriteLine("Premi 3 - Modifica quantità prodotto/Dettaglio già presente");
    Console.WriteLine("Premi 4 - Stampa Carrello");
    Console.WriteLine("Premi 0 - Exit");

    int scelta;
    do
    {
        Console.Write("\nFai la tua scelta: ");
    } while (!int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 4);

    switch (scelta)
    {
        case 1:
            if (listaProdotti.Count > 0)
            {
                //stampa prodotti disponibili
                Console.WriteLine("\n\n------------------Elenco prodotti disponibili----------------");
                foreach (var item in listaProdotti)
                {
                    Console.WriteLine(item.GetInfo());
                }
                Console.WriteLine("-----------------------------------------------------------------");
                
                
                //scelgo prodotto tramite un codice
                Console.Write("Immetti codice prodotto: ");
                string codice = Console.ReadLine();
                //Verifico se esiste quel codice prodotto e recupero il prodotto
                Prodotto p = GestioneECommerce.CercaProdottoPerCodice(codice);
                if (p == null)
                {
                    Console.WriteLine("Codice prodotto non valido");
                }
                else
                {
                    //Chiediamo di specificare la quantità
                    int quantita;
                    do
                    {
                        Console.WriteLine("immetti quantità: ");
                    } while (!int.TryParse(Console.ReadLine(), out quantita) && quantita > 0);

                    //Scorro la lista degli ordini nel mio carrello per vedere se esiste
                    //già un Dettaglio relativo allo stesso prodotto
                    bool esiste = false;
                    foreach (var item in user.Carrello.DettagliOrdine)
                    {
                        if (item.Prodotto == p)
                        {
                            item.Quantita += quantita;
                            esiste = true;
                        }
                    }
                    if (esiste == false)
                    {
                        //posso creare un Dettaglio da aggiungere nel carrello
                        DettaglioOrdine dettaglio = new DettaglioOrdine();
                        dettaglio.Prodotto = p;
                        dettaglio.Quantita = quantita;
                        user.Carrello.DettagliOrdine.Add(dettaglio); //aggiunto alla lista degli ordini del carrello dell'utente
                        Console.WriteLine($"Dettaglio aggiunto con successo nel carrello: \n{dettaglio.GetInfo()}");
                    }
                    else
                    {
                        Console.WriteLine("Il prodotto era già presente. e' stata aggiornata la quantità");
                    }
                }
            }
            else
            {
                Console.WriteLine("Nessun Prodotto disponibile.");
            }
            break;
        case 2:
            user.Carrello.StampaCarrello();
            Console.WriteLine("Il dettaglio relativo a quale prodotto vuoi eliminare? \n Inserisci codice prodotto valido: ");
            string c = Console.ReadLine();
            DettaglioOrdine OrdDaEliminare = GestioneECommerce.CercaDettaglioPerCodiceProdotto(c, user.Carrello);
            if (OrdDaEliminare == null)
            {
                Console.WriteLine("Codice prodotto errato e/o non presente nel carrello");
            }
            else
            {
                user.Carrello.DettagliOrdine.Remove(OrdDaEliminare);
                Console.WriteLine("Dettaglio eliminato");
            }
            break;
        case 3:
            user.Carrello.StampaCarrello();
            Console.WriteLine("La quantità di quale prodotto vuoi modificare? \nInserisci codice prodotto");
            string codProd = Console.ReadLine();
            DettaglioOrdine o = GestioneECommerce.CercaDettaglioPerCodiceProdotto(codProd, user.Carrello);
            if (o == null)
            {
                Console.WriteLine("Codice Prodotto errato e/o non presente nel carrello");
            }
            else
            {
                int newQuantita;
                do
                {
                    Console.WriteLine("Immetti quantità: ");
                } while (!int.TryParse(Console.ReadLine(), out newQuantita) && newQuantita > 0);

                o.Quantita = newQuantita;
                Console.WriteLine("Quantità aggiornata");
            }
            break;
        case 4:
            user.StampaUtente();
            user.Carrello.StampaCarrello();
            break;
        case 0:
            return;
    }

} while (true);
        