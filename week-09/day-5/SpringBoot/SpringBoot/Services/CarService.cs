using SpringBoot.Models;
using SpringBoot.Repositories;
using System.Collections.Generic;

namespace SpringBoot.Services
{
    public class CarService
    {
        private CarRepository carRepository;

        public CarService(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public List<LicencePlate> GetByBrand(string brand)
        {
            return carRepository.FilterBrand(brand);
        }

        public List<LicencePlate> GetFilteredList(FilterOptions filterOptions)
        {
            if(filterOptions.Q != null)
            {
                return carRepository.FilterPlate(filterOptions.Q);
            }
            else if(filterOptions.Police == 1)
            {
                return carRepository.FilterPolice();
            }
            else if (filterOptions.Diplomat == 1)
            {
                return carRepository.FilterDiplomat();
            }
            return carRepository.GetPlates();
        }
    }
}
