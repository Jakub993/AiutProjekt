using System;

namespace Backend.Entities
{
    public class TechResearch
    {
        public int Id { get; set; }
        public DateTime DateOfTechnicalInspectionOfVehicle { get; set; }
        public DateTime DateOfNextVehicleInspection { get; set; }
        public bool IsEfficient { get; set; }
    }
}
