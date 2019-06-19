using System.ComponentModel.DataAnnotations;

namespace XiaoLin.VNADS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}