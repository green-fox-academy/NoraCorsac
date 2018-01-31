using SpringBoot.Entities;
using SpringBoot.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpringBoot.Repositories
{
    public class CarRepository
    {
        private CarContext carContext;

        public CarRepository(CarContext carContext)
        {
            this.carContext = carContext;
        }

        public List<LicencePlate> GetPlates()
        {
            return carContext.LicencePlates.ToList();
        }

        public List<LicencePlate> FilterPlate(string q)
        {
            return carContext.LicencePlates.Where(l => l.Plate.Contains(q)).ToList();
        }

        public List<LicencePlate> FilterPolice()
        {
            return carContext.LicencePlates.Where(l => l.Plate.StartsWith("RB")).ToList();
        }

        public List<LicencePlate> FilterDiplomat()
        {
            return carContext.LicencePlates.Where(l => l.Plate.StartsWith("DT")).ToList();
        }

        public List<LicencePlate> FilterBrand(string brand)
        {
            return carContext.LicencePlates.Where(l => l.CarBrand.Equals(brand)).ToList();
        }
    }
}
