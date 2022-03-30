// See https://aka.ms/new-console-template for more information
using Palestra_OOP;

Console.WriteLine("Hello, World!");
Utente utente = null;
Abbonamento abbonamento = null;

bool continua = true;
while (continua)
{
    Menu();
    int scelta = Scegli();
    switch (scelta)
    {
        case 1:
            InserisciDati(ref utente, ref abbonamento);
            break;
        case 2:
            CalcolaAbbonamento();
            break;
        case 3:
            abbonamento.StampaAbbonamento();
            break;
        case 0:
            Console.WriteLine("Ciao Ciao");
            continua = false;
            break;
    }
}

void CalcolaAbbonamento()
{
    Console.WriteLine($"Abbonamento calcolato: {abbonamento.AbbonamentoTotale} euro");
    Console.WriteLine($"Corri a stampare il preventivo con tutti i dettagli");
}

void Menu()
{
    Console.WriteLine("---------Menu------------");
    Console.WriteLine("1. Inserisci i tuoi dati");
    Console.WriteLine("2. Calcola Abbonamento");
    Console.WriteLine("3. Stampa Preventivo Abbonamento");
    Console.WriteLine("0. Exit");
}

int Scegli()
{
    int scelta;
    do
    {
        Console.Write("Fai la tua scelta tra le possibili voci del menu: ");
    } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 3));
    return scelta;
}

void InserisciDati(ref Utente utente, ref Abbonamento abbonamento)
{
    Console.WriteLine("Inserisci il tuo nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Inserisci il tuo cognome: ");
    string cognome = Console.ReadLine();
    DateTime dataNascita;
    do
    {
        Console.WriteLine("Inserisci la data di nascita: ");
    } while (!(DateTime.TryParse(Console.ReadLine(), out dataNascita) && dataNascita.Year < DateTime.Now.Year));

    utente = new Utente(nome, cognome, dataNascita); //creo l'utente

    Console.WriteLine("Che tipo di abbonamento vorresti?");
    Console.WriteLine("Opzioni: \nAnnuale\nSemestrale\nTrimestrale\nMensile");
    TipoAbbonamento tipo;
    while (!(Enum.TryParse(Console.ReadLine(), out tipo) && Enum.IsDefined(typeof(TipoAbbonamento), tipo)))
    {
        Console.WriteLine("Inserisci un'opzione tra quelle disponibili!");
    }
    abbonamento = new Abbonamento(utente, tipo);
}


