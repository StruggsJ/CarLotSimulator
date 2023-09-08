using System;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot carLot = new CarLot();

            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Bronco";
            car1.Year = 2024;
            car1.IsDrivable = true;
            
            carLot.CarList.Add(car1);
            Console.WriteLine($"There is currently a car in the lot.");

            Console.WriteLine(car1.EngineSound(car1.EngineNoise));
            Console.WriteLine(car1.HonkSound(car1.HonkNoise));
            Console.WriteLine("");

            Car car2 = new Car
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2023,
                EngineNoise = "WRRRR WRRRR",
                HonkNoise = "BEEEE",
                IsDrivable = true

            };

            carLot.CarList.Add(car2);
            Console.WriteLine($"There are currently {CarLot.numberOfCars} cars in the lot.");

            Console.WriteLine(car2.EngineSound(car2.EngineNoise));
            Console.WriteLine(car2.HonkSound(car2.HonkNoise));
            Console.WriteLine("");

            Car car3 = new Car("Jeep", "Grand Cherokee", 2019, "GRRRRRRRRT", "BEEEEEEP BEEEEEP", true);

            carLot.CarList.Add(car3);
            Console.WriteLine($"There are currently {CarLot.numberOfCars} cars in the lot.");

           Console.WriteLine(car3.EngineSound(car3.EngineNoise));
           Console.WriteLine(car3.HonkSound(car3.HonkNoise));
           Console.WriteLine("");

           Console.WriteLine("------------");

          

                foreach (var car in carLot.CarList)
                {

                    //carLot - List Name, CarList - List Name in CarLot Class, IndexOf() - Method Name; added 1 to account for index 0.

                    int lotNumber = carLot.CarList.IndexOf(car) + 1; 

                   Console.WriteLine($"Lot #{lotNumber}: {car.Year} {car.Make} {car.Model}");

                }

           
           
        }
     }
 }

