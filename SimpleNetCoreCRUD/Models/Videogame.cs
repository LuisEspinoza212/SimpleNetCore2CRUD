using System.ComponentModel.DataAnnotations;

namespace SimpleNetCoreCRUD.Models
{
    public class Videogame
    {
        
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Publisher { get; set; }
    }
}
