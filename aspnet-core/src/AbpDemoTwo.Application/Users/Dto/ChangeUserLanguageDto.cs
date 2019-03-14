using System.ComponentModel.DataAnnotations;

namespace AbpDemoTwo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}