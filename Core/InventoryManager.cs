namespace MyFirstApp.Core
{
    using MyFirstApp.Models;
    public class InventoryManager
    {
        public List<ClotheViewModel> clothes = new List<ClotheViewModel>();
        public void AddClothe(int id, int number, string model, string size, string category)
        {
            var newclothe = new ClotheViewModel(id, number, model, size, category);
            clothes.Add(newclothe);
        }
    }
}
