using System;
namespace CarLotSimulator
{
    public class Car
    {
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
            Console.WriteLine($"Engine noise of {Make} {Model} sounds like {noise}");
        }

        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine($"Honk noise of {Make} {Model} sounds like {noise}");
    }   }

}