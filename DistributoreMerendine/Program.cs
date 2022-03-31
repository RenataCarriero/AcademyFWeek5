// See https://aka.ms/new-console-template for more information
Console.WriteLine("Distributore Merendine");
//Erogazione Merendine(usare Dictionary):
//Mostrare un menu all’utente per far scegliere la merendina desiderata (scelta tra 4 merendine):
//Esempio:
//Scegli:
//1 per Buondì: prezzo 1 €
//2 per Patatine: prezzo 0.5 €
//..
//
//Una volta scelta la merendina, chiedere all’utente di inserire i soldi.
//Se i soldi inseriti sono meno del prezzo allora chiedere di nuovo l’aggiunta di soldi
//e sommarli a quelli già inseriti quindi rieffettuare il controllo fino al raggiungimento
//o superamento del prezzo della merendina scelta.
//Se il totale dei soldi inseriti è uguale al prezzo della merendina allora mostrare a video “Erogazione merendina”.
//Se il totale dei soldi supera il prezzo della merendina, mostrare a video “Erogazione merendina” ed
//anche il messaggio con il resto “Resto erogato : X.XX €”.

var codiciMerendine = new Dictionary<int, string>();
codiciMerendine.Add(1, "Buondì");
codiciMerendine.Add(2, "Patatine");
codiciMerendine.Add(3, "Focaccine");
var prezziMerendine = new Dictionary<string, decimal>();
prezziMerendine.Add("Buondì", (decimal)1.50);
prezziMerendine.Add("Patatine", (decimal)2.00);
prezziMerendine.Add("Focaccine", (decimal)1.00);
while (true)
{
    Console.WriteLine("Ciao.");
    //visualizzazione prodotti
    Console.WriteLine("Lista prodotti:");

    foreach (var item in codiciMerendine)
    {
        Console.WriteLine($"Codice {item.Key}: {item.Value}, prezzo {prezziMerendine[item.Value]} euro");
    }
    
    //scelta prodotto
    int codice = 0;
    do
    {
        Console.WriteLine("Digita un codice prodotto");
        
    } while (!(int.TryParse(Console.ReadLine(), out codice) && codiciMerendine.ContainsKey(codice)));

    Console.WriteLine($"Hai scelto il codice {codice}");
    Console.WriteLine($"Inserisci euro {prezziMerendine[codiciMerendine[codice]]}");

    //Inserimento monete
    decimal cash = 0;    //monete che inserisco
    decimal cashTot = 0; //totale monete
    decimal resto = 0;
    do
    {
        cash = decimal.Parse(Console.ReadLine()); //TODO (tryParse)
        cashTot = cashTot + cash;
        if (cashTot < prezziMerendine[codiciMerendine[codice]])
        {
            Console.WriteLine($"Aggiungi euro {prezziMerendine[codiciMerendine[codice]] - cashTot}");
        }

    }
    while (cashTot < prezziMerendine[codiciMerendine[codice]]);
    resto = cashTot - prezziMerendine[codiciMerendine[codice]];

    //erogazione prodotto
    Console.WriteLine($"Erogazione prodotto {codiciMerendine[codice]}");
    Console.WriteLine($"Il resto è di {resto} euro ");
}

