
namespace LibraryDataModel.Models
{
    public class BorrowingRecord : BaseEntity
    {
        public DateTime BorrowDate { get; set; }

        public int BookId { get; set; }

        public virtual Book? Book { get; set; }

        public int? CardId { get; set; }

        public virtual Card? Card { get; set; }

        public Status Status
        {
            get
            {
                if ((DateTime.Now - BorrowDate).TotalDays > 15) return Status.borrowed;
                else if ((DateTime.Now - BorrowDate).TotalDays > 15 && (DateTime.Now - BorrowDate).TotalDays < 18) return Status.late;
                else return Status.penalize;
            }
        }

        public int NotificationId { get; set; }

        public virtual Notification? Notification { get; set; }
    }

    public enum Status
    {
        borrowed,
        late,
        penalize
    }
}
