using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RigetZooAdventures.Data;

namespace RigetZooAdventures.Models
{
    public class Article
    {
        [Key]
        [Display(Name = "Article Id")]
        public int ArticleId { get; set; }

        [Required]
        [Display(Name = "Article Name")]
        [MaxLength(750)]
        public string ArticleName { get; set; }

        [Display(Name = "User Id")]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [MaxLength(5000)]
        public string? Content { get; set; }


        [DataType(DataType.ImageUrl)]
        public string? ImageURL { get; set; }

        [Required]
        [Display(Name = "Last Edited")]
        [DataType(DataType.Time)]
        public DateTime LastEdited { get; set; }
    }
}
