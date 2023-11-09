namespace daw_lab4.Models
{
    public class GetStireDto
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Lead { get; set; }
        public string Continut { get; set; }
        public string Autor { get; set; }
        public int CategorieId { get; set; }

        /*public GetStireDto(string titlu, string lead, string continut, string autor, int categorieId)
        {
            Titlu = titlu;
            Lead = lead;
            Continut = continut;
            Autor = autor;
            CategorieId = categorieId;
        }*/
    }
}