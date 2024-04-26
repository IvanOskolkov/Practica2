using System;
class Train
{
    public int TrainNumber { get; set; }
    
    public string Destination { get; set; }
    
    public DateTime DepartureTime { get; set; }

    public void TrainInfo()
    {
        Console.WriteLine($"Номер поезда:      {TrainNumber}");
        Console.WriteLine($"Номер назначения:  {Destination}");
        Console.WriteLine($"Время направления: {DepartureTime}");
    }
}

class Program
{
    static void Main()
    {
        Train train = new Train
        {
            Destination = "Новосибириск",
            TrainNumber = 254,
            DepartureTime = new DateTime(2020, 10, 15, 12, 45, 0)
        };

        Console.WriteLine("Напишите номер поезда: ");
        int userTrainNumber = int.Parse(Console.ReadLine());

        if (userTrainNumber == train.TrainNumber)
        {
            train.TrainInfo();
        }
        else
        {
            Console.WriteLine("Поезда под таким номером нету");
        }
    }
    
}