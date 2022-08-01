namespace CommandPattern
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage door going up");
        }

        public void Down()
        {
            Console.WriteLine("Garage door going down");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door stopped");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage door light on");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage door light off");
        }
    }
}