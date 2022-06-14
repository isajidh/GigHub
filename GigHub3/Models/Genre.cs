using System.ComponentModel.DataAnnotations;

namespace GigHub3.Models
{
    public class Genre
    {
        public byte ID { get; set; }

        [Required(ErrorMessage = "Genre name is required")]
        [StringLength(255)]
        public string Name { get; set; }
    }
}