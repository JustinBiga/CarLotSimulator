using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.NumberOfCars++;
        }

        //Properties
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

     
        // Methods
        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($"Engine noise of {Year} {Make} {Model} sounds like {noise}");
        }

        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine($"Honk noise of {Year} {Make} {Model} sounds like {noise}");


        }

    }
    

   


}