namespace UPPDB.Models.Entities
{
    public class OrderEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public CustomerEntity? Customer { get; set; }

        public List<OrderRowEntity>? OrderRows { get; set; }

    }
}
