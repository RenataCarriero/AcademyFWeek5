namespace Amazon
{
    internal class DettaglioOrdine
    {
        public Prodotto Prodotto { get; set; } = new Prodotto();
        public int Quantita { get; set; }


        public double PrezzoPieno { get { return Prodotto.Prezzo * Quantita; } } //prezzo del prodotto * quantita

        public double PrezzoScontato { get { return CalcolaPrezzoScontato(); } }

        private double CalcolaPrezzoScontato()
        {
            return PrezzoPieno - ((PrezzoPieno * Prodotto.Sconto) / 100);
        }

        public DettaglioOrdine()
        {

        }

        public DettaglioOrdine(Prodotto prodotto, int quantita)
        {
            Prodotto = prodotto;
            Quantita = quantita;
        }

        public string GetInfo()
        {
            return $"\n{Prodotto.GetInfo()} \t n° {Quantita} \nPrezzo Pieno: {PrezzoPieno}euro \t Prezzo scontato: {PrezzoScontato}euro";
        }
    }
}