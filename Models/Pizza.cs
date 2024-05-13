namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }
        public float Price { get; set; }

        public Pizza(string name, string desc, string imgPath, float price)
        {
            Name = name;
            Description = desc;
            ImgPath = imgPath;
            Price = price;
        }
    }
}
