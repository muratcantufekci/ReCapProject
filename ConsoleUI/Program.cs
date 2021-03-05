using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var car in productManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.ReadKey();
        }

    }
}
