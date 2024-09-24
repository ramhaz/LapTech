using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using LapTech.Models;


namespace LapTech.Helpers
{
    public class JsonFileReader
    {
        public static List<CPU> ReadJsonCpu(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);

            return JsonSerializer.Deserialize<List<CPU>>(jsonString);
        }

        public static List<GPU> ReadJsonGpu(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonSerializer.Deserialize<List<GPU>>(jsonString);
        }

        public static List <Laptop> ReadJsonLaptop(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonSerializer.Deserialize<List<Laptop>>(jsonString);
        }

        public static List <Spil> ReadJsonSpil(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonSerializer.Deserialize<List<Spil>>(jsonString);
        }
    }
}
