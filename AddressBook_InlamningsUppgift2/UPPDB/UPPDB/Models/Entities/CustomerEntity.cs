using System.ComponentModel.DataAnnotations;

namespace UPPDB.Models.Entities
{
    public class CustomerEntity
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = null!;  
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public List<OrderEntity>? Orders { get; set; } 

    }
}
