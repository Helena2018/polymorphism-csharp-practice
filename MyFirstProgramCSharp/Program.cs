namespace MyFirstProgramCSharp;
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bycicle bycicle = new Bycicle();
        Boat boat = new Boat();

        Vehicle[] vehicles = {car, bycicle, boat};

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.Go();
        }


        Console.ReadKey();
    }

}
class Vehicle
{
    public virtual void Go()
    {

    }

}
class Car : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("The car is going!");
    }
}
class Bycicle : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("The bycicle is going!");
    }
}
class Boat : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("The boat is going!");
    }
}
