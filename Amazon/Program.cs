// See https://aka.ms/new-console-template for more information
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
Ogni carrello può contenere diversi ordini; ogni ordine è costituito dalle seguenti informazioni:
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
