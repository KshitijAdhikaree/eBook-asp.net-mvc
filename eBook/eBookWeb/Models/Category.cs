using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayName("Order")]
        [Range(1,100,ErrorMessage ="Order should not be greater than 100!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
