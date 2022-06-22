using System;

namespace Backend.Models
{
    public class VehicleDTO
    {
        public string VehicleBrand { get; set; }
        public string RegistrationNumber { get; set; }
        public string VehicleModel { get; set; }
        public DateTime DateOfFristTechInspection { get; set; }
        public DateTime DateOfCurrentTechInspection { get; set; }
        //Do zmiany to pod spodem :p
        public bool IsTechInpsectionUpToDate { get; set; }
        public DateTime DateOfNextVehicleInspection { get; set; }
        public bool IsTechInspectionOutOfDate { get; set; }
    }
}
