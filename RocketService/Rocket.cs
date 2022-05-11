namespace RocketService
{
    public class Rocket
    {
        public int Speed { get; set; } = 0;
        public bool EnginesAreWorking { get; set; }
        public string Direction { get; set; } = "No direction...";

        public void FlyToTheMoon()
        {
            Speed = 29000;
            EnginesAreWorking = true;
            Direction = "To the Moon!";
        }
    }
}