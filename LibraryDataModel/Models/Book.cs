using System.ComponentModel.DataAnnotations;

namespace LibraryDataModel.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = string.Empty; 

        public string ISBN { get; set; } = string.Empty; 

        public bool IsExceptional { get; set; }

        public int? CategoryId { get; set; }

        public virtual BookCategory? BookCategory { get; set; }

        public virtual ICollection<BorrowingRecord>? BorrowingRecords { get; set; }
    }
}
