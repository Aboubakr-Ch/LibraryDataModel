using System.Collections.ObjectModel;

namespace LibraryDataModel.Models
{
    public class Notification : BaseEntity
    {
        public string Message { get; set; } = string.Empty;

        public virtual ICollection<BorrowingRecord>? BorrowingRecords { get; set; } 
    }
}
