using System.ComponentModel.DataAnnotations;

namespace LibraryApplicationSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}