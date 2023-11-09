namespace daw_lab4.Models
{
    public class CategorieDto
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public ICollection<Stire> Stiri { get; set; }
    }
}
