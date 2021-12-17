using MyFirstApp.Models;

namespace MyFirstApp.Controllers
{
    using System.Collections.Generic;

     public class ClothController
    {
       public List<ClotheViewModel> clothes = new List<ClotheViewModel>();
        public void AddClothe(int id,int number,string model,string size,string category)
        {
            var newclothe = new ClotheViewModel( id, number, model, size, category );
            clothes.Add(newclothe);
        }
        public ClotheViewModel FindClotheById(int srchId)
        {
            var tempClothes = clothes.Where(c => c.id == srchId);
            return tempClothes;
        }
        public ClotheViewModel FindClotheByModel(string srchModel)
        {
            var tempClothes = clothes.Where(c => c.model == srchModel);
            return tempClothes;
        }
    }
}
