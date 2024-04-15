using System;

public class Engine
{
    public void Start()
    {
        Console.WriteLine("Двигатель запущен");
    }
}

public abstract class Transport
{
    protected Engine engine;

    public Transport(Engine engine)
    {
        this.engine = engine;
    }

    public abstract void Move();
}

public class Car : Transport
{
    public Car(Engine engine) : base(engine)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Машина начала движение");
        engine.Start();
    }
}

public class Plane : Transport
{
    public Plane(Engine engine) : base(engine)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Самолет начал полет");
        engine.Start();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Engine carEngine = new Engine();
        Car car = new Car(carEngine);
        car.Move();

        Console.WriteLine();

        Engine planeEngine = new Engine();
        Plane plane = new Plane(planeEngine);
        plane.Move();

        Console.ReadLine();
    }
}
