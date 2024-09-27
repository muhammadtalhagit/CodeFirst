namespace CodeFirstApi.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }


    }
}
