﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI;

public class Program
{
    static void Main(string[] args)
    {
        var carManager = new CarManager(new InMemoryCarDal());
        
        foreach(var car in carManager.GetAll())
        {
            Console.WriteLine(car.Description);
        }
    }
}