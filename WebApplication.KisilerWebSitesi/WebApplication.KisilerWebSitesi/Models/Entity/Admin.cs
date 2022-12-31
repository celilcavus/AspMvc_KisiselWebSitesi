using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.KisilerWebSitesi.Models.Entity
{
    public class Admin
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string username { get; set; }
        [Required,DataType(DataType.Password),MaxLength(16)]
        public string password { get; set; }
    }
}