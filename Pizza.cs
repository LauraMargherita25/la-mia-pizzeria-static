namespace la_mia_pizzeria_static
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public int Price { get; set; }

        public Pizza (string name, string description, string img, int price)
        {
            this.Name = name;
            this.Description = description;
            this.Img = img;
            this.Price = price;
        }
    }
}