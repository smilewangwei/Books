using System.ComponentModel.DataAnnotations;

namespace BookList.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}