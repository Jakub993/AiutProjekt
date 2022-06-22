using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("[controller]")]
    public class BackendController : ControllerBase
    {
        private IVehicleService VehicleService;
        public BackendController(IVehicleService vehicleService)
        {
            VehicleService = vehicleService;
        }

        [HttpGet]
        public ActionResult<List<VehicleDTO>> GetVehicleData()
        {
            var result = VehicleService.GetAllVehicle();
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("post")]
        public ActionResult<List<VehicleDTO>> PostVehcileData([FromBody] )
        {

        }
    }
}
