namespace TheSorrowOfTheGreatPavel.Models
{
    public class KyrsListModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public List <KyrsModel> KyrsModels { get; set; }
    }
}
