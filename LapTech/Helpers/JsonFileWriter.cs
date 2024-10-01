using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using LapTech.Models;



namespace LapTech
{
    public class JsonFileWriter
    {
        public static void WriteToJsonCpu(List<CPU> Cpu, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(Cpu, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
        public static void WriteToJsonGpu(List<GPU> Gpu, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(Gpu, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
        public static void WriteToJsonLaptop(List<Laptop> Laptop, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(Laptop, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
    

}
