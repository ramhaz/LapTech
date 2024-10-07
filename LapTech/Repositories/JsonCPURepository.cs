using LapTech.Interfaces;
using LapTech.Models;
using System.Collections.Generic;

namespace LapTech.Repositories
{
    public class JsonCPURepository : ICPURepository
    {
        private readonly string JsonCPUPath = "C:\\Users\\halil\\OneDrive\\Dokumenter\\GitHub\\LapTech\\LapTech\\Data\\CPU.json"; 

        public List<CPU> GetAllCPUs()
        {
            return JsonFileReader.ReadJsonCpu(JsonCPUPath);
        }
    }
}

