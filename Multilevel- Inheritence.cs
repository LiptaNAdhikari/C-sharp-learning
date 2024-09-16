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
public class Cat : Dog
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing");
    }
}
class Result
{
    public static void Main(string[] args)
    {
        Cat c = new Cat();
        c.Eat();
        c.Bark();
        c.Meow();
    }
}
