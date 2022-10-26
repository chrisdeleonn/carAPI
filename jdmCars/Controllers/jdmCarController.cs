using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jdmCarAPI.Controllers
{
    [Route("api/[controller]")]
    public class jdmCarController : Controller
    {
        private static List<jdmCar> cars = new List<jdmCar>
            {
                new jdmCar {
                    Id = 1,
                    Name = "Mazda",
                    Country = "Japan",
                    Model = "RX-7",
                    Year = "1991"}
        };
        // 
        [HttpGet]
        public async Task<ActionResult<List<jdmCar>>> Get()
        {
   
            return Ok(cars);
        }
        //
        [HttpPost]
        public async Task<ActionResult<List<jdmCar>>> AddCar(jdmCar car)
        {
            cars.Add(car);
            return Ok(cars);
        }
    }
}