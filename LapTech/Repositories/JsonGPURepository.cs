using LapTech.Interfaces;
using LapTech.Models;
using System.Collections.Generic;

namespace LapTech.Repositories
{
    public class JsonGPURepository : IGPURepository
    {
        private readonly string JsonGPUPath = "C:\\Users\\halil\\OneDrive\\Dokumenter\\GitHub\\LapTech\\LapTech\\Data\\GPU.json"; // Specify the correct path to your GPU.json file

        public List<GPU> GetAllGPUs()
        {
            return JsonFileReader.ReadJsonGpu(JsonGPUPath);
        }
    }
}
