using System;
using System.Collections.Generic;

//making a public class
public class BankoPlate
{
    public string Name { get; set; }
    public List<int> Row1 { get; set; }
    public List<int> Row2 { get; set; }
    public List<int> Row3 { get; set; }

    public BankoPlate(string name, List<int> row1, List<int> row2, List<int> row3) 
    {
        Name = name;
        Row1 = row1;
        Row2 = row2;
        Row3 = row3;
    }
}

//making a class called program, to store lists
class Program 
{
    static void Main(string[] args)
    {
        //Creating list and ids
        // Alexander 1
        List<int> plate1Row1 = new List<int>() { 4, 0, 21, 0, 42, 0, 0, 71, 80 };
        List<int> plate1Row2 = new List<int>() { 6, 15, 0, 33, 0, 58, 0, 0, 82 };
        List<int> plate1Row3 = new List<int>() { 8, 17, 25, 0, 0, 0, 63, 75, 0 };

        //Alexander 2
        List<int> plate2Row1 = new List<int>() { 0, 10, 22, 32, 45, 0, 0, 0, 82 };
        List<int> plate2Row2 = new List<int>() { 6, 0, 23, 33, 48, 0, 63, 0, 0 };
        List<int> plate2Row3 = new List<int>() { 0, 18, 0, 39, 49, 57, 0, 78, 0 };

        //Alexander 3
        List<int> plate3Row1 = new List<int>() { 0, 13, 24, 0, 0, 51, 64, 0, 82 };
        List<int> plate3Row2 = new List<int>() { 2, 14, 25, 0, 42, 52, 0, 0, 0 };
        List<int> plate3Row3 = new List<int>() { 0, 0, 0, 39, 46, 54, 67, 78, 0 };

        List<BankoPlate> bankoPlates = new List<BankoPlate>();
        bankoPlates.Add(new BankoPlate("Alexander 1", plate1Row1, plate1Row2, plate1Row3));
        bankoPlates.Add(new BankoPlate("Alexander 2", plate2Row1, plate2Row2, plate2Row3));
        bankoPlates.Add(new BankoPlate("Alexander 3", plate3Row1, plate3Row2, plate3Row3));

        int chosenNumber = 0;

        int newNumber;

        
        foreach (BankoPlate plate in bankoPlates)
        {
            Console.WriteLine($"Plate Name: {plate.Name}");
            int numberToSpace = 0;
            Console.WriteLine("Row 1:");
            foreach (int zero in plate.Row1)
            if (zero != 0)
            {
                Console.Write(zero + " ");
                    Console.Write(zero == numberToSpace ? $"\u0336{zero}\u0336 " : $"{"| "}" );
            }
            Console.WriteLine("\nRow 2:");
            foreach (int zero in plate.Row2)
            if (zero != 0)
            {
                Console.Write(zero + " ");
                    Console.Write(zero == numberToSpace ? $"\u0336{zero}\u0336 " : $"{"| "}");
            }
            Console.WriteLine("\nRow 3:");
            foreach (int zero in plate.Row3)
            if (zero != 0)
            {
                Console.Write(zero + " ");
                    Console.Write(zero == numberToSpace ? $"\u0336{zero}\u0336 " : $"{"| "}");
            }
            Console.WriteLine("\n-----------------\n");
        }
        Console.ReadLine();
    }
}

