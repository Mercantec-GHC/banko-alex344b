using System;
using System.Collections.Generic;

//making a public class
public class BankoPlate
{
    public string Name { get; set; }
    public List<int> Row1 { get; set; }
    public List<int> Row2 { get; set; }
    public List<int> Row3 { get; set; }
    public List<int>[] Rows { get; set; }

    public BankoPlate(string name, List<int> row1, List<int> row2, List<int> row3)
    {
        Name = name;
        Row1 = row1;
        Row2 = row2;
        Row3 = row3;
        Rows = new List<int>[3] { row1, row2, row3 };
    }
}

//making a class called program, to store lists
class Program
{
    static List<int> enteredNumbers = new List<int>();

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

        //Alexander 4
        List<int> plate4Row1 = new List<int>() { 2, 0, 0, 33, 42, 54, 61, 0, 0 };
        List<int> plate4Row2 = new List<int>() { 4, 15, 25, 0, 47, 0, 0, 0, 84 };
        List<int> plate4Row3 = new List<int>() { 0, 16, 0, 37, 0, 59, 0, 79, 85 };

        //Listing the plates in order
        List<BankoPlate> bankoPlates = new List<BankoPlate>();
        bankoPlates.Add(new BankoPlate("Alexander 1", plate1Row1, plate1Row2, plate1Row3));
        bankoPlates.Add(new BankoPlate("Alexander 2", plate2Row1, plate2Row2, plate2Row3));
        bankoPlates.Add(new BankoPlate("Alexander 3", plate3Row1, plate3Row2, plate3Row3));
        bankoPlates.Add(new BankoPlate("Alexander 4", plate4Row1, plate4Row2, plate4Row3));

        int chosenNumber = 0;

        int newNumber;

        //making a while true loop to contain the code so its in a loop
        while (true)
        {
            //in this foreach loop it iterates over a collection of objects of type 'BankoPlate' in the bankoPlates collection
            foreach (BankoPlate plate in bankoPlates)
            {
                //int number to space is the number that needs to be made into nothing so its not visable
                int numberToSpace = 0;

                // here we make it print out when there is banko and on wich plate
                bool bankoRow1 = CheckFullRows(plate.Row1);
                bool bankoRow2 = CheckFullRows(plate.Row2);
                bool bankoRow3 = CheckFullRows(plate.Row3);

                string result = "";
                if (bankoRow1 == true)
                {
                    result += $"BANKO ROW1! {plate.Name} -";
                }

                if (bankoRow2 == true)
                {
                    result += $"BANKO! ROW2 {plate.Name} - ";
                }

                if (bankoRow3 == true)
                {
                    result += $"BANKO! ROW3! {plate.Name}";
                }

                Console.WriteLine(result);

                //here we format the plates in the console GUI
                Console.WriteLine($"Plate Name: {plate.Name}");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Row{i+1}:");
                    foreach (int zero in plate.Rows[i])
                    {
                        if (zero != 0)
                        {
                            if (enteredNumbers.Contains(zero))
                            {
                                Console.Write("X ");
                            }
                            else
                            {
                                Console.Write(zero + " ");
                            }
                            Console.Write($"{"| "}");

                        }

                    }
                    Console.WriteLine();
                }
                
                Console.WriteLine("\n-----------------\n");
            }

            //Here we store our used/typed in numbers and print them in the console GUI
            chosenNumber = int.Parse(Console.ReadLine());
            enteredNumbers.Add(chosenNumber);
            Console.WriteLine("Used numbers");
            foreach (int number in enteredNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n-----------------\n");
            //Console.ReadKey();
            Console.Clear();
        }

        /*Here we make sure that ChechFullRows takes a list of integers and puts them out as boolean value
         * The purpose is to check if all non-zero numbers is the given in the list are present in another collection named enteredNumbers.
        */
        bool CheckFullRows(List<int> row)
        {
            foreach (int number in row)
            {

                if (!enteredNumbers.Contains(number) && number != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
