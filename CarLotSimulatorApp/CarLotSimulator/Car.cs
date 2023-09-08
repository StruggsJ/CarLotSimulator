using System;

public class Car
{
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property

    public Car()
	{
        CarLot.numberOfCars++;
    }

    public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDrivable)
    {
        Make = make;
        Model = model;  
        Year = year;    

        EngineNoise = engineNoise;  
        HonkNoise = honkNoise;  

        IsDrivable = isDrivable;    

        CarLot.numberOfCars++;
    }

    public string Make { get; set;  }
    public string Model { get; set; }
    public int Year { get; set; }

    public string EngineNoise { get; set; } = "Brrrrrt Brrrt";
    public string HonkNoise { get; set; } = "Beep Beep";

    public bool IsDrivable { get; set; } = true;

    public string EngineSound(string sound)
    {
        return $"The {Year} {Make} {Model}'s engine sounds like this: {sound}"; 
    }
     
    public string HonkSound(string sound)
    {
        return $"The {Year} {Make} {Model}'s horn sounds like this: {sound}";
    }
}
