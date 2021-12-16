namespace MyFirstApp.Models
{
    public class ClotheViewModel
    {
        public int id { get; set; }
        public int number { get; set; }
        public string model { get; set; }
        public string size { get; set; }
        public string category { get; set; }

        public ClotheViewModel(int id, int number, string model, string size, string category)
        {
            this.id = id;
            this.number = number;
            this.model = model;
            this.size = size;
            this.category = category;
        }

    }
}
