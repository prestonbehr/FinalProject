using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address(
            "100 College Avenue",
            "Rexburg",
            "Idaho",
            "USA"
        );

        Lecture lecture = new Lecture(
            "How to Learn C#",
            "A beginner lecture about learning C# programming",
            "July 25 2026",
            "6:00 PM",
            lectureAddress,
            "James Carter",
            100
        );

        Address receptionAddress = new Address(
            "55 Garden Lane",
            "Boise",
            "Idaho",
            "USA"
        );

        Reception reception = new Reception(
            "Wedding Reception",
            "A reception celebrating a newly married couple",
            "August 10 2026",
            "7:00 PM",
            receptionAddress,
            "rsvp@email.com"
        );

        Address outdoorAddress = new Address(
            "10 Park Road",
            "Salt Lake City",
            "Utah",
            "USA"
        );

        OutdoorGathering outdoor = new OutdoorGathering(
            "Community Picnic",
            "A picnic for families in the community",
            "September 5 2026",
            "12:00 PM",
            outdoorAddress,
            "Sunny with a high of 78 degrees"
        );

        Console.WriteLine("LECTURE STANDARD DETAILS");
        Console.WriteLine(lecture.GetStandardDetails());

        Console.WriteLine();
        Console.WriteLine("LECTURE FULL DETAILS");
        Console.WriteLine(lecture.GetFullDetails());

        Console.WriteLine();
        Console.WriteLine("LECTURE SHORT DESCRIPTION");
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine();
        Console.WriteLine("----------------------------");
        Console.WriteLine();

        Console.WriteLine("RECEPTION STANDARD DETAILS");
        Console.WriteLine(reception.GetStandardDetails());

        Console.WriteLine();
        Console.WriteLine("RECEPTION FULL DETAILS");
        Console.WriteLine(reception.GetFullDetails());

        Console.WriteLine();
        Console.WriteLine("RECEPTION SHORT DESCRIPTION");
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine();
        Console.WriteLine("----------------------------");
        Console.WriteLine();

        Console.WriteLine("OUTDOOR GATHERING STANDARD DETAILS");
        Console.WriteLine(outdoor.GetStandardDetails());

        Console.WriteLine();
        Console.WriteLine("OUTDOOR GATHERING FULL DETAILS");
        Console.WriteLine(outdoor.GetFullDetails());

        Console.WriteLine();
        Console.WriteLine("OUTDOOR GATHERING SHORT DESCRIPTION");
        Console.WriteLine(outdoor.GetShortDescription());
    }
}