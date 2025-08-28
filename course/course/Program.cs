using System;

class Course
{
    protected void Showdetails()
    {
        Console.WriteLine("showing course details");
    }
}
class OnlineCourse : Course
{
    public void display ()
    {
        Showdetails();
    }
}
class program
{
    static void Main()
    {
        var onlineCourse =  new OnlineCourse();
        onlineCourse.display();
    }
}
