using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WaterPlantsAPI.Models;
using WaterPlantsAPI.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WaterPlantsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("OpenCORSPolicy")]
    public class WaterPlantsController : ControllerBase
    {

        private readonly IPlantRepository _plantRepository;
        public WaterPlantsController(IPlantRepository plantRepository)
        {
            _plantRepository = plantRepository;
        }
        // GET: api/<WaterPlantsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Plant>>> GetAllPlants()
        {
            var plants = await _plantRepository.GetPlants();
            return Ok(plants);
        }

        // GET api/<WaterPlantsController>/5
        [HttpGet("{id}")]
        public Plant Get(int id)
        {
           var existingplant =  _plantRepository.GetPlant(id);

            return existingplant ;
        }

        // POST api/<WaterPlantsController>
        [HttpPost]
        public async Task<ActionResult<Plant>> Post([FromBody] Plant plant)
        {
            await _plantRepository.AddPlant(plant);
            return Ok();
        }

        // PUT api/<WaterPlantsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlant( int id)
        {
          


            await _plantRepository.UpdatePlant( id);
            
           
            return Ok();
        }

        // DELETE api/<WaterPlantsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
