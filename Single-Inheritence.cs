using System;
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}
class Result
{
    public static void Main(string[] args)
    {
        Dog d = new Dog();
        d.Bark();
        d.Eat(); // Eat method is inherited from Animal class
    }
}
