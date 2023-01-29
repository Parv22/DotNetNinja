using System;
    
public class ConstructorsAndDestructors
{
    public static void Main(string[] args)
    {
        int totalFamilyMembers = 3;
        Person[] persons = new Person[totalFamilyMembers];

        Console.WriteLine("Enter names for your family members");
    
        for (int i = 0; i < totalFamilyMembers; i++)
        {
            persons[i] = new Person(Console.ReadLine());
        }
    
        for (int i = 0; i < totalFamilyMembers; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }
    }
    
    public class Person
    {
        private string _name { get; set; }
    
        public Person(string name)
        {
            _name = name;
        }
    
        public override string ToString()
        {
            return "You Entered -> " + _name;
        }
    
        ~Person()
        {
            _name = string.Empty;
        }
    }
}