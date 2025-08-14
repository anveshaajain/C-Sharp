using System;

class Course
{
    protected void ShowDetails()
    {
        Console.WriteLine("Showing course details");
    }
}

class OnlineCourse : Course
{
    public void Display()
    {
        ShowDetails();
    }
}

class Program
{
    static void Main()
    {
        var onlineCourse = new OnlineCourse();
        onlineCourse.Display();
    }
}
