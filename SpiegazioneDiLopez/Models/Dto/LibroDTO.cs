namespace SpiegazioneDiLopez.Models.Dto
{
    public class LibroDTO
    {
        public string autore { get; set; }
        public string genere { get; set; }
        public string titolo { get; set; }
        public string isbn { get; set; }
        public LibroDTO(string isbn, string autore, string genere, string titolo)
        {
            this.isbn = isbn;
            this.autore = autore;
            this.genere = genere;
            this.titolo = titolo;
        }
    }
}
