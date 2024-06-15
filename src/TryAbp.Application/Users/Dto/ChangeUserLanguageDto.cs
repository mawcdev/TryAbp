using System.ComponentModel.DataAnnotations;

namespace TryAbp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}