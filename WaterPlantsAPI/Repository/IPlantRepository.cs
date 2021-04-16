using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterPlantsAPI.Models;

namespace WaterPlantsAPI.Repository
{
    public interface IPlantRepository
    {
        Task<IEnumerable<Plant>> GetPlants();
        Task AddPlant(Plant plant);
        Task UpdatePlant(int id);
        Plant GetPlant(int id);
    }
}
