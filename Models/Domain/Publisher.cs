using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Domain
{
    public class Publisher
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}