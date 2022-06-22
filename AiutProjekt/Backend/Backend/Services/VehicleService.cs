using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class VehicleService : IVehicleService
    {
        public VehicleService()
        {

        }

        public List<VehicleDTO> GetAllVehicle() => new List<VehicleDTO>()
        {
            new VehicleDTO()
            {
                VehicleBrand = "Hyundai",
                VehicleModel = "Getz",
                IsTechInpsectionUpToDate = true,
                IsTechInspectionOutOfDate = false,
                RegistrationNumber = "SGL112233X",
                DateOfCurrentTechInspection = new DateTime(2022, 01, 01),
                DateOfFristTechInspection = new DateTime(2005, 01, 01),
                DateOfNextVehicleInspection = new DateTime(2023, 01, 01)
            }
        };
    }
}
