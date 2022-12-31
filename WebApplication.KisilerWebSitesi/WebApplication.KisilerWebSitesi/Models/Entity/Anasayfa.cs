using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.KisilerWebSitesi.Models.Entity
{
    public class Anasayfa
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [   
            Required,
            MaxLength(100)
        ]
        public string Image { get; set; }
        [Required,MaxLength(60)]
        public string NameAndSurname { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }
        [Required, MaxLength(int.MaxValue)]
        public string Abaout { get; set; }
        [Required, MaxLength(int.MaxValue)]
        public string Contact { get; set; }

    }
}