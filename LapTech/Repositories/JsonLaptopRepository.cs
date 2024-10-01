using LapTech.Models;
using LapTech.Interfaces;
using LapTech.Data;


namespace LapTech.Repositories
{
    public class JsonLaptopRepository : ILaptopRepository
    {
        private string JsonGPUPath = new Paths().JsonGPUPath;
        private string JsonCPUPath = new Paths().JsonCPUPath;
        private string JsonLaptopPath = new Paths().JsonLaptopPath;

        private List<Laptop> LaptopList;

        public void CreateLaptop(Laptop laptop)
        {
            LaptopList = JsonFileReader.ReadJsonLaptop(JsonLaptopPath);
            int Id = 1; 
            if (LaptopList.Any())
            {
                Id = LaptopList.Max(x => x.Id) + 1;
            }
            laptop.Id = Id;
            LaptopList.Add(laptop);
            JsonFileWriter.WriteToJsonLaptop(LaptopList.OrderBy(x => x.Id).ToList(), JsonLaptopPath);

        }

        public void DeleteLaptop(int Id)
        {
            LaptopList = JsonFileReader.ReadJsonLaptop(JsonLaptopPath);
            LaptopList.RemoveAll(s => s.Id == Id);
            JsonFileWriter.WriteToJsonLaptop(LaptopList, JsonLaptopPath);
        }

        public List <Laptop> GetAllLaptops()
        {
            return JsonFileReader.ReadJsonLaptop(JsonLaptopPath);
        }

        public Laptop GetLaptopById(int id)
        {
            foreach (var laptop in JsonFileReader.ReadJsonLaptop(JsonLaptopPath))
            {
                if (laptop.Id == id)
                {
                    return laptop;
                }
                
            }
            return new Models.Laptop();
        }

        public void UpdateLaptop(Laptop laptop)
        {
            if (laptop != null)
            {
                LaptopList = JsonFileReader.ReadJsonLaptop(JsonLaptopPath);
                LaptopList.RemoveAll(s => s.Id == laptop.Id);
                LaptopList.Add(laptop);
                JsonFileWriter.WriteToJsonLaptop(LaptopList, JsonLaptopPath);
            }
        }   
    }
}
