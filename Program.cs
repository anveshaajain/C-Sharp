using System;

class lucky_ticket
{
    static void Main()
    {
        for(int i=1; i <=100; i++)
            if (i%12==0)
                Console.WriteLine("Lucky tickets are: "+ i);
    }
}
