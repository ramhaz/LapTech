namespace LapTech.Interfaces
{
    public interface ILaptopRepository
    {
        void CreateLaptop(Laptop laptop);
        void DeleteLaptop(Laptop laptop);
        void UpdateLaptop(Laptop laptop);
        Laptop GetLaptopById(int id);
        List<Laptop> GetAllLaptops();

    }
}
