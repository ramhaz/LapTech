using LapTech.Models;

namespace LapTech.Interfaces
{
    public interface IGPURepository
    {
        List<GPU> GetAllGPUs();
    }
}
