﻿using HouseF;

try
{
    HouseFactory factory = new HouseFactory();

    House houseWithPool = factory.CreateHouse("housewithpool");

    House deluxeHouse = factory.CreateHouse("belairdeluxehouse");

    House tinyHouse = factory.CreateHouse("tinyhouse");

    House standardHouse = factory.CreateHouse("standardhouse");

    House houseWithPoolAndGarage = factory.CreateHouse("housewithpoolandgarage");

    House houseWithNoName = factory.CreateHouse("housewithnoname");

    Console.WriteLine(houseWithPool);
    Console.WriteLine(deluxeHouse);
    Console.WriteLine(tinyHouse);
    Console.WriteLine(standardHouse);
    Console.WriteLine(houseWithPoolAndGarage);
    Console.WriteLine(houseWithNoName);
}
catch (KeyNotFoundException ke)
{
    Console.WriteLine(ke.Message);
}



