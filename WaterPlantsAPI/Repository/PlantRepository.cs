using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterPlantsAPI.Data;
using WaterPlantsAPI.Models;

namespace WaterPlantsAPI.Repository
{
    public class PlantRepository : IPlantRepository
    {
        private readonly PlantDbContext _context;
        public PlantRepository(PlantDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Plant>> GetPlants()
        {
            var plants = await _context.Plant.ToListAsync();
            return plants;
        }
        public async Task AddPlant(Plant plant)
        {
            await _context.Plant.AddAsync(plant);
            await _context.SaveChangesAsync();
        }
        public async Task UpdatePlant(int id)
        {

            var existingPlant = _context.Plant.Where(s => s.Id == id).FirstOrDefault();

            DateTime lastWatered = DateTime.Now;
            existingPlant.Id =id;
                existingPlant.lastWatered = lastWatered;

                await _context.SaveChangesAsync();
            
          
        }
        public Plant GetPlant(int id)
        {
            var existingPlant =  _context.Plant.Where(s => s.Id == id).FirstOrDefault();
                                                   
            return existingPlant;

        }

    }
}
