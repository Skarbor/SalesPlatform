namespace ProductsService.Dtos
{
    public class ProductReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}