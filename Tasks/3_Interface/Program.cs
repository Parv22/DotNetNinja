using System;

public class Tester {

    public static void Main(String[] args) {
        Car car = new Car(0);
        Console.WriteLine("Created car object with 0 fuel");
        car.Drive();

        Console.WriteLine("Please refuel");
        int fuel = int.Parse(Console.ReadLine());
        car.Refuel(fuel);
        car.Drive();
    }
}


public interface IVehicle {
    void Drive();
    bool Refuel(int amountOfFuel);
}

public class Car : IVehicle {
    protected int _amountOfFuelLeft {get; set;}
    public Car(int amountOfFuel){
        this._amountOfFuelLeft = amountOfFuel;
    }

    public void Drive() {
        if(this._amountOfFuelLeft > 0){
            Console.WriteLine("Car is driving new fuel level is {0}",this._amountOfFuelLeft);
        }
        else {
            Console.WriteLine("No fuel, can't drive.");
        }
    }

    public bool Refuel(int amountOfFuel){
        this._amountOfFuelLeft += amountOfFuel;
        return true;
    }
}