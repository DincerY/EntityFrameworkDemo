// See https://aka.ms/new-console-template for more information
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using Entities.Concrete;




CarManager carManager = new CarManager(new EfCarDal());

//carManager.Add(new Car { Id=1,BrandId = 1, ColorId = 2, DailyPrice = 1591, Descriptionn = "Mercedes C Serisi", ModelYear = 2019 });
//carManager.Add(new Car { Id=2,BrandId = 4, ColorId = 3, DailyPrice = 1647, Descriptionn = "Volvo XC40", ModelYear = 2020 });
//carManager.Add(new Car { Id = 3, BrandId = 5, ColorId = 7, DailyPrice = 1988, Descriptionn = "Audi TT", ModelYear = 2021 });

foreach (var car in carManager.GetAll()) 
{
    Console.WriteLine(car.Descriptionn);
}