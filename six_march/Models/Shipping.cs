using System.ComponentModel.DataAnnotations;

namespace six_march.Models
{
    public class Shipping
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Tittle { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public string Image { get; set; }

    }
}