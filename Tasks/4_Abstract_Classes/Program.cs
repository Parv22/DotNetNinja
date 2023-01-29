public class Tester{
    public static void Main(){
        Console.WriteLine("Please enter name of your dog");
        string nameOfDog = Console.ReadLine();

        Dog dog = new Dog();
        dog.Name = nameOfDog;
        dog.Eat();

    } 
}

public abstract class Animal{
    public string Name {set; get;}

    public abstract void Eat();
}

public class Dog : Animal{
    public override void Eat(){
        Console.WriteLine("{0} is eating.",this.Name);
    }
}

