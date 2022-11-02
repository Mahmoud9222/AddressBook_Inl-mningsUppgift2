namespace UPPDB.Models.Entities
{
    public class OrderRowEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public OrderEntity? Order { get; set; }
        //public ProductEntity? Product { get; set; }
    }
}
