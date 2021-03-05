using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
     public class InMemoryProductDal : IProductDal
    {
        List<Car> _cars;
        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
               new Car{Id=1, BrandId =1, ColorId=1, ModelYear= 2020, DailyPrice=150, Description="Fiat mavi araba"},
               new Car{Id=2, BrandId =2, ColorId=2, ModelYear= 2016, DailyPrice=120, Description="Opel kırmızı araba"},
               new Car{Id=3, BrandId =2, ColorId=1, ModelYear= 2008, DailyPrice=100, Description="Opel mavi araba"},
               new Car{Id=4, BrandId =3, ColorId=3, ModelYear= 2019, DailyPrice=140, Description="Bmw beyaz araba"},
               new Car{Id=5, BrandId =4, ColorId=4, ModelYear= 2015, DailyPrice=100, Description="Mercedes kırmızı araba"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            var carByBrandId = _cars.Where(x => x.BrandId == brandId).ToList();
            return carByBrandId;
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(x => x.Id == car.Id);
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
        }
    }
}
