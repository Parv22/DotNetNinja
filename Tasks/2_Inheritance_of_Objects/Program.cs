using System;

public class InheritanceDemo {

    public static void Main(string[] args){
        int totalPersons = 3;
        Person[] persons = new Person[totalPersons];

        for(int i=0; i < totalPersons; i++){

            if(i==0){
                Console.WriteLine("Enter name of the Teacher");
                persons[i] = new Teacher(Console.ReadLine());
            }
            else{
                Console.WriteLine("Enter name of the Student {0}",i);
                persons[i] = new Student(Console.ReadLine());
            }           
        }

        for(int i=0; i < totalPersons; i++){
            if(i ==0){
                ((Teacher)persons[i]).Explain();
            }
            else {
                ((Student)persons[i]).Study();
            }
        }
    }
}



public class Person {
    protected string Name {get; set;}

    public Person(string? name){
        Name = name;
    } 
}

public class Student : Person {

    public Student(string name) : base(name) {
    }

    public void Study() {
        Console.WriteLine("Student {0} is studying",this.Name);    
    }
}

public class Teacher: Person {

    public Teacher(string name) : base(name){
    }

    public void Explain() {
        Console.WriteLine("Teacher {0} is explaining.",this.Name);    
    }
}