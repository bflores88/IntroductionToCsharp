using System;


class Program
{
    static void Main()
    {
        int? TicketsOnSale = 100;

        int AvailableTickets = TicketsOnSale ?? 0;
        
        Console.WriteLine("AvailableTickets = {0}", AvailableTickets);

    }
}