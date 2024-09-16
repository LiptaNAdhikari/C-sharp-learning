using System;

class Book
{
    public string name;
    public string subject;

    public void Readers(string n, string s)
    {
        name = n;
        subject = s;
        Console.WriteLine("Name: " + name + "\nSubject: " + subject);
    }
}

class Student : Book
{
    public void Read(string n, string s)
    {
        Console.WriteLine(n + " is reading " + s);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Readers("Liptan","Math");
        s1.Read("Liptan","Math");
    }
}
