namespace WebApplication1.Models
{
    public class ProductsSampleData
    {
        List<Products> products;
        public ProductsSampleData() 
        {
            products = new List<Products>();
            products.Add(new Products() { Id=1 , Name="IPhone1" , Price = 10000 , Image="1.jpg" , Description="phone1" });
            products.Add(new Products() { Id=2 , Name="IPhone2" , Price = 1500 , Image="2.png" , Description="phone2" });
            products.Add(new Products() { Id=3 , Name="IPhone3" , Price = 10600 , Image="1.jpg" , Description="phone3" });
            products.Add(new Products() { Id=4 , Name="IPhone4" , Price = 10087 , Image="3.png" , Description="phone4" });
        }

        public List<Products> GetAll()
        {
            return products;
        }

        public Products GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}
