using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars {

            get
            {
                return new List<Car>
                {
                    new Car{
                        name = "Tesla",
                        shortDesc="фцаывц", longDesc = "фцвфцфв",
                        img = "./../Pictures/Catalog/Image/rocket.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car{
                        name = "FEef",
                        shortDesc="фцаывц", longDesc = "фцвфцфв",
                        img = "./../Pictures/Catalog/Image/rocket.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    }
                };
            }
               
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjextCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
