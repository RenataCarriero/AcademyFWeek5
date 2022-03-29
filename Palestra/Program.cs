// See https://aka.ms/new-console-template for more information

//Abbonamento Palestra
//Realizzare un’applicazione console che consenta di eseguire il calcolo dell’abbonamento in palestra.
//Si richiede di sviluppare un menù attraverso cui l’utente può scegliere di:
//Inserire i propri dati per sottoscrivere l’abbonamento (nome, cognome e data di nascita);
//Richiedere il calcolo del costo dell’abbonamento annuale che è costituito da una quota fissa di
//20€  se si ha meno di 25 anni
//50€  dai 26 anni in su
//Più la tariffa mensile di 30 euro.
//Stampare a video i valori dell’abbonamento, inclusi nome, cognome e costo totale pagato.
//Ciascuna delle operazioni descritte sopra dovrà essere implementata attraverso una opportuna routine.
Console.WriteLine("Palestra - Calcolo preventivo abbonamento");

string nome = null, cognome = null;
DateTime dataDiNascita = new DateTime();
double abbonamentoTotale = 0;
const double quotaFissaGiovani = 20;
const double quotaFissaAdulti = 50;
int mesi = 0;
const double quotaFissaMensile = 30;
int eta = 0;

bool continua = true;
while (continua == true)
{
    Menu();
    int scelta = Scegli();

    switch (scelta)
    {
        case 1:
            InserisciDati(ref nome, ref cognome, ref eta, ref mesi);             
            break;
        case 2:
            CalcolaAbbonamento(ref abbonamentoTotale);
            break;
        case 3:
            StampaAbbonamento(nome, cognome, abbonamentoTotale, eta, mesi);
            break;
        case 0:
            Console.WriteLine("Ciao!");
            continua = false;
            break;
        default:
            Console.WriteLine("Scelta errata. Riprova.");            
            break;
    }

}

void StampaAbbonamento(string? nome, string? cognome, double abbonamentoTotale, int eta, int mesi)
{
    Console.WriteLine($"\n\nPreventivo abbonamento {(TipoAbbonamento)mesi} di {nome} {cognome}");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"Totale da pagare: {abbonamentoTotale} euro");
    Console.WriteLine("\nDettaglio:");
    if (eta <= 25)
    {
        Console.WriteLine($"Età: {eta} quindi quota fissa = {quotaFissaGiovani} euro ");
    }
    else
    {
        Console.WriteLine($"Età: {eta} quindi quota fissa = {quotaFissaAdulti} euro ");
    }
    Console.WriteLine($"A cui va aggiunta la quota mensile {quotaFissaMensile} euro per {mesi} mesi ovvero {mesi* quotaFissaMensile} euro");
}

void CalcolaAbbonamento(ref double abbonamentoTotale)
{
    abbonamentoTotale = mesi * quotaFissaMensile;
    if (eta <= 25)
    {
        abbonamentoTotale += quotaFissaGiovani; //abbonamentoTotale = abbonamentoTotale + quotaFissaGiovani;
    }
    else
    {
        abbonamentoTotale += quotaFissaAdulti;
    }
    Console.WriteLine("Preventivo calcolato. Corri a stamparlo!");
}

void InserisciDati(ref string? nome, ref string? cognome, ref int eta, ref int mesi)
{
    Console.WriteLine("Inserisci nome: ");
    nome=Console.ReadLine();
    Console.WriteLine("Inserisci cognome: ");
    cognome = Console.ReadLine();

    do
    {
        Console.WriteLine("Inserisci la data di nascita: ");
    } while (!(DateTime.TryParse(Console.ReadLine(), out dataDiNascita) && DateTime.Now.Year-dataDiNascita.Year>=16));

    eta = DateTime.Now.Year - dataDiNascita.Year;

    Console.WriteLine("Che tipo di abbonamento vorresti?");
    Console.WriteLine("Opzioni: \nAnnuale\nSemestrale\nTrimestrale\nMensile");
    TipoAbbonamento tipo;
    do
    {
        Console.WriteLine("Scegli tra le possibili opzioni: ");
    } while (!(Enum.TryParse(Console.ReadLine().ToLower(), out tipo) && Enum.IsDefined(typeof(TipoAbbonamento), tipo)));
    mesi = (int)tipo;
}



int Scegli()
{
    int sceltaUtente;
    do
    {
        Console.Write("Fai la tua scelta tra le possibili voci del menu: ");
    } while (!(int.TryParse(Console.ReadLine(), out sceltaUtente) /*&& sceltaUtente>=0 && sceltaUtente<=3*/));
    return sceltaUtente;
}

void Menu()
{
    Console.WriteLine("-----------MENU------------");
    Console.WriteLine("1. Inserisci i tuoi dati");
    Console.WriteLine("2. Calcola preventivo Abbonamento");
    Console.WriteLine("3. Stampa preventivo Abbonamento");
    Console.WriteLine("0. Exit");
}

enum TipoAbbonamento
{
    annuale=12,
    semestrale=6,
    trimestrale=3,
    mensile=1
}