using LapTech.Models;
using LapTech.Interfaces;
using LapTech.Data;

namespace LapTech.Repositories
{
    public class JsonLaptopRepository
    {
        private string JsonGPUPath = new Paths().JsonGPUPath;
        private string JsonCPUPath = new Paths().JsonCPUPath;
        private string JsonLaptopPath = new Paths().JsonLaptopPath;

        private List<Laptop> LaptopList;

        public void CreateLaptop(Laptop laptop)
        {
            throw new NotImplementedException;
        }

        public void DeleteLaptop(Laptop laptop)
        {
            throw new NotImplementedException;
        }

        public List <Laptop> GetAllLaptops()
        {
            return JsonFile
        }

        public Laptop GetLaptopById(int id)
        {
            throw new NotImplementedException;
        }

        public void UpdateLaptop(Laptop laptop)
        {
            throw new NotImplementedException;
        }   
    }
}
