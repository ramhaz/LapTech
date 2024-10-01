using LapTech.Models;

namespace LapTech.Interfaces
{
    public interface ILaptopRepository
    {
        void CreateLaptop(Laptop laptop);
        void DeleteLaptop(int id);
        void UpdateLaptop(Laptop laptop);
        Laptop GetLaptopById(int id);
        List<Laptop> GetAllLaptops();

    }
}
