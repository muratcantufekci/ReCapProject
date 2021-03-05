using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Car> GetByBrandId(int id);

        List<Car> GetAll();

        void Add(Car car);

        void Delete(Car car);

        void Update(Car car);
    }
}
