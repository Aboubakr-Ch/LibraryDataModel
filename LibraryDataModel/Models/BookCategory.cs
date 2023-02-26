namespace LibraryDataModel.Models
{
    public class BookCategory : BaseEntity
    {
        public string CategoryLabel { get; set; } = string.Empty;

        public virtual ICollection<Book>? Books { get; set; }
    }
}
