namespace SpiegazioneDiLopez.Models
{
    public class Libro
    {
        public string isbn { get; set; }
        public string autore { get; set; }
        public string genere { get; set; }
        public string titolo { get; set; }

        public Libro(string isbn, string autore, string genere, string titolo) { 
            this.isbn = isbn;
            this.autore = autore;
            this.genere = genere;
            this.titolo = titolo;
        }
    }
}
