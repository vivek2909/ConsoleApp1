using System;
public class Vehicle
{
    public string brand = "Mahindra";
    public void honk()
    {
        Console.WriteLine("Peep, Peep");
    }
}
class Car : Vehicle
{
    public string modelName = "XUV 700";
}
class program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.honk();
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}

