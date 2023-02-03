using System;
using System.Collections;

public class Tester{
    public static void Main(string[] args){

        int TotalPersons = 3;

        ArrayList List = new ArrayList();

        for(int i=0;i<TotalPersons;i++){
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = int.Parse(Console.ReadLine());

            Person p = new Person(name,age);
            List.Add(p); 
        }

        for(int i =0; i<TotalPersons; i++){
            Console.WriteLine(List[i].ToString());
        }

    }
}

public class Person{

    public string Name {get; set;}
    public int Age {get; set;}

    public Person(string name, int age){
        if(age <= 0){
            throw new Exception("age has to be a postive number");
        }

        this.Name = name;
        this.Age = age;        
    }

    public override string ToString()
    {
        return $"{this.Name} is {this.Age} years old";
    }
}