namespace ProductsService.Dtos
{
    public class ProductCreateDto
    {
        public string Name { get; set; }  
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}