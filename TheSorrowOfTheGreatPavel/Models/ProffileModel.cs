namespace TheSorrowOfTheGreatPavel.Models
{
    public class ProffileModel
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public DateTime CreatedDate { get; set; }

        public KyrsListModel KyrsListModel { get; set; }
    }
}
