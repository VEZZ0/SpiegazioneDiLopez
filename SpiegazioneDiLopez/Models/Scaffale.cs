using SpiegazioneDiLopez.Models.Dto;

namespace SpiegazioneDiLopez.Models
{
    public static class Scaffale
    {
        public static List<LibroDTO> listaLibri = new List<LibroDTO>();
        static Scaffale()
        {
            listaLibri = new List<LibroDTO>
            {
                new LibroDTO ( "Autobiografia di Anna Frank", "Anna Frank", "horror" , "dfhjgjdhjdh"),
                new LibroDTO ( "Autobiografia di Barbie", "Barbie", "Fantasy", "ahahahahah" ),
                new LibroDTO ( "Biografia di Lopez", "Lopez", "Saggistica", "lopezzzzzzzzzzzz" )
            };
        }
        public static List<LibroDTO> getListaLibri() => listaLibri;
    }
}
