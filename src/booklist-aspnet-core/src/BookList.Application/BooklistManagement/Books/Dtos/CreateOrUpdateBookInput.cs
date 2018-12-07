using System.ComponentModel.DataAnnotations;

namespace BookList.BooklistManagement.Books.Dtos
{
    public class CreateOrUpdateBookInput
    {
        [Required]
        public BookEditDto Book { get; set; }
    }
}