using LapTech.Interfaces;
using LapTech.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace LapTech.Pages
{
    public class AllLaptopsModel : PageModel
    {
        private readonly ILaptopRepository _laptopRepository;
        private readonly IGPURepository _gpuRepository;
        private readonly ICPURepository _cpuRepository;

        public List<Laptop> Laptops { get; set; }

        public AllLaptopsModel(ILaptopRepository laptopRepository, IGPURepository gpuRepository, ICPURepository cpuRepository)
        {
            _laptopRepository = laptopRepository;
            _gpuRepository = gpuRepository;
            _cpuRepository = cpuRepository;
        }

        public void OnGet()
        {
            // Load laptops, GPUs, and CPUs
            var laptops = _laptopRepository.GetAllLaptops();
            var gpus = _gpuRepository.GetAllGPUs();
            var cpus = _cpuRepository.GetAllCPUs();

            // Link GPUs and CPUs to Laptops
            foreach (var laptop in laptops)
            {
                laptop.GPU = gpus.FirstOrDefault(g => g.Id == laptop.GPUId);
                laptop.CPU = cpus.FirstOrDefault(c => c.Id == laptop.CPUId);
            }

            Laptops = laptops;
        }
    }
}
