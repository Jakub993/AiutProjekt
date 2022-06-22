using Backend.Models;
using System.Collections.Generic;

namespace Backend.Services
{
    public interface IVehicleService
    {
        List<VehicleDTO> GetAllVehicle();
    }
}
