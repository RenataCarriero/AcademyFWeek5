namespace Amazon
{
    internal class Prodotto
    {
        public string Codice { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Sconto { get; set; } = 0; //sconto in percentuale

        public Prodotto()
        {

        }

        public Prodotto(string codice, string descrizione, double prezzo, int sconto)
        {
            Codice = codice;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Sconto = sconto;
        }

        public string GetInfo()
        {
            return $"Codice: {Codice} \t Descrizione:{Descrizione} \t Prezzo: {Prezzo} euro \t Sconto: {Sconto}%";
        }
    }
}