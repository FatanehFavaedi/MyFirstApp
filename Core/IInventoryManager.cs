using MyFirstApp.Models;
namespace MyFirstApp.Core
{
    public interface IInventoryManager
    {
        void AddClothe(int id, int number, string model, string size, string category);
        ClotheViewModel FindClotheById(int ID);
        ClotheViewModel FindClotheByModel(string srchModel);
    }
}
