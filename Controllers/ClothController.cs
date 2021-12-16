using MyFirstApp.Models;

namespace MyFirstApp.Controllers
{
    public class ClothController
    {
       public List<ClotheViewModel> clothes = new List<ClotheViewModel>();
        public AddItem(int id,int number,string model,string size,string category)
        {
            var newclothe = new ClotheViewModel( id, number, model, size, category );
            clothes.Add(newclothe);
            return;
        }
    }
}
