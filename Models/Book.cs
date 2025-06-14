using SQLite;
namespace BookDatabase.Models
{
    public class Book
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
    }
}