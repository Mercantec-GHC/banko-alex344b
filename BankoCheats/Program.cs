using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Runtime.InteropServices;

//creating lists and ids
//Alexander 1
List<int> plate1Row1 = new List<int> { 4, 0, 21, 0, 42, 0, 0, 71, 80 };
List<int> plate1Row2 = new List<int> { 6, 15, 0, 33, 0, 58, 0, 0, 82 };
List<int> plate1Row3 = new List<int> { 8, 17, 25, 0, 0, 0, 63, 75, 0 };

//Alexander 2
List<int> plate2Row1 = new List<int> { 0, 10, 22, 32, 45, 0, 0, 0, 82 };
List<int> plate2Row2 = new List<int> { 6, 0, 23, 33, 48, 0, 63, 0, 0 };
List<int> plate2Row3 = new List<int> { 0, 18, 0, 39, 49, 57, 0, 78, 0 };

//Alexander 3
List<int> plate3Row1 = new List<int> { 0, 13, 24, 0, 0, 51, 64, 0, 82 };
List<int> plate3Row2 = new List<int> { 2, 14, 25, 0, 42, 52, 0, 0, 0 };
List<int> plate3Row3 = new List<int> { 0, 0, 0, 39, 46, 54, 67, 78, 0 };

//Creating a public class to store the banko plates.
public class BankoPlate
{
    string name;
    List<int> row1;
    List<int> row2;
    List<int> row3;
    public BankoPlate(string name, List<int> row1, List<int> row2, List<int> row3) 
    {
        this.name = name;
        this.row1 = row1;
        this.row2 = row2;
        this.row3 = row3;
    }
}

List<BankoPlate> bankoPlates = new List<BankoPlate>();
bankoPlates.Add(new BankoPlate("Alexander 1", plate1Row1, plate1Row2, plate1Row3));
bankoPlates.Add(new BankoPlate("Alexander 2", plate2Row1, plate2Row2, plate2Row3));
bankoPlates.Add(new BankoPlate("Alexander 3", plate3Row1, plate3Row2, plate3Row3));

foreach (BankoPlate plate in bankoPlates)
{
    for (int i = 0; i < 9; i++)

}

// Storing the chosen number
int chosenNumber = 0;

int newNumber;

bool fullRow1 =  false;
bool fullRow2 =  false;
bool fullRow3 =  false;

// Starting pahse 1
/*
int gamePhase = 1;
while (true)
{
    Console.WriteLine("Indsæt det trukket nummer");
    // Showing current game phase and plate
    //plate one
    for (int i = 0; i < 1; i++)
    {
        var formattedRow = plate1Row1.Select(val => val == 0 ? " " : val == -1 ? "XX" : val.ToString());
        Console.WriteLine($"{string.Join("|", formattedRow)}");
    }
    
    for (int i = 0; i < 1; i++)
    {
        var formattedRow = plate1Row2.Select(val => val == 0 ? " " : val == -1 ? "XX" : val.ToString());
        Console.WriteLine($"{string.Join("|", formattedRow)}");
    }
    
    for (int i = 0; i < 1; i++)
    {
        var formattedRow = plate1Row3.Select(val => val == 0 ? " " : val == -1 ? "XX" : val.ToString());
        Console.WriteLine($"{string.Join("|", formattedRow)}");
    }
    Console.WriteLine();

    //plate 2
    for (int i = 0; i < 1; i++)
    {
        var formattedRow = plate2Row1.Select(val => val == 0 ? " " : val == -1 ? "XX" : val.ToString());
        Console.WriteLine($"{string.Join("|", formattedRow)}");
    }
    
    for (int i = 0; i < 1; i++)
    {
        var formattedRow = plate2Row2.Select(val => val == 0 ? " " : val == -1 ? "XX" : val.ToString());
        Console.WriteLine($"{string.Join("|", formattedRow)}");
    }
    
    for (int i = 0; i < 1; i++)
    {
        var formattedRow = plate2Row3.Select(val => val == 0 ? " " : val == -1 ? "XX" : val.ToString());
        Console.WriteLine($"{string.Join("|", formattedRow)}");
    }
    Console.WriteLine();

    //plate 3
    for (int i = 0; i < 1; i++)
    {
        var formattedRow = plate3Row1.Select(val => val == 0 ? " " : val == -1 ? "X" : val.ToString());
        Console.WriteLine($"{string.Join("|", formattedRow)}");
    }
    
    for (int i = 0; i < 1; i++)
    {
        var formattedRow = plate3Row2.Select(val => val == 0 ? " " : val == -1 ? "X" : val.ToString());
        Console.WriteLine($"{string.Join("|", formattedRow)}");
    }
    
    for (int i = 0; i < 1; i++)
    {
        var formattedRow = plate3Row3.Select(val => val == 0 ? " " : val == -1 ? "X" : val.ToString());
        Console.WriteLine($"{string.Join("|", formattedRow)}");
    }
    Console.WriteLine();

    // Get the chosen number and input
    try
    {
        chosenNumber = int.Parse(Console.ReadLine()); // converter til int (Try string.empty)
    }
    catch
    {
        Console.WriteLine("INSERT NUMBER, YOU ONLY HAVE 1 MORE TRY! OR I WILL EAT YOUR MOM!");
        chosenNumber = int.Parse(Console.ReadLine()); // converter til int
    }
    

    //Updating game phase based on input
    switch (gamePhase)
    {
        case 1: // 1 Full row on the first plate
            if (plate1Row1.Contains(chosenNumber) && chosenNumber != 0)
            {
                newNumber = plate1Row1.IndexOf(chosenNumber);
                plate1Row1[newNumber] = -1;
            }
            else if (plate1Row2.Contains(chosenNumber) && chosenNumber != 0)
            {
                newNumber = plate1Row2.IndexOf(chosenNumber);
                plate1Row2[newNumber] = -1;
            }
            else if (plate1Row3.Contains(chosenNumber) && chosenNumber != 0)
            {
                newNumber = plate1Row3.IndexOf(chosenNumber);
                plate1Row3[newNumber] = -1;
            }

            // Populating temp array
            plate1Array1 = plate1Row1.ToArray().Where(x => x != 0).ToArray();
            plate1Array2 = plate1Row2.ToArray().Where(x => x != 0).ToArray();
            plate1Array3 = plate1Row3.ToArray().Where(x => x != 0).ToArray();

            if (plate1Array1.AsQueryable().All(x => x == -1 && x != 0) ||
                plate1Array2.AsQueryable().All(x => x == -1 && x != 0) ||
                plate1Array3.AsQueryable().All(x => x == -1 && x != 0))

            {
                Console.WriteLine("1 full row obtained!\n Click enter to continue!");
                fullRow1 = true;
                Console.ReadLine();
                Console.Clear();
                gamePhase = 2;
            }
            else
            {
                Console.Clear();
            }
            break;

        case 2: // 2 Full rows on plate 1
            if (plate1Row1.Contains(chosenNumber) && chosenNumber != 0)
            {
                newNumber = plate1Row1.IndexOf(chosenNumber);
                plate1Row1[newNumber] = -1;
            }
            else if (plate1Row2.Contains(chosenNumber) && chosenNumber != 0)
            {
                newNumber = plate1Row2.IndexOf(chosenNumber);
                plate1Row2[newNumber] = -1;
            }
            else if (plate1Row3.Contains(chosenNumber) && chosenNumber != 0)
            {
                newNumber = plate1Row3.IndexOf(chosenNumber);
                plate1Row3[newNumber] = -1;
            }
            // Refreshing the temp array
            plate1Array1 = plate1Row1.ToArray().Where(x => x != 0).ToArray();
            plate1Array2 = plate1Row2.ToArray().Where(x => x != 0).ToArray();
            plate1Array3 = plate1Row3.ToArray().Where(x => x != 0).ToArray();

            if (plate1Array2.AsQueryable().All(x => x == -1 && x != 0) && plate1Array1.AsQueryable().All(x => x == -1 && x != 0) ||
                plate1Array1.AsQueryable().All(x => x == -1 && x != 0) && plate1Array3.AsQueryable().All(x => x == -1 && x != 0) ||
                plate1Array3.AsQueryable().All(x => x == -1 && x != 0) && plate1Array2.AsQueryable().All(x => x == -1 && x != 0))
              
            {
                Console.WriteLine("2 full rows obtained!\n Click enter to continue!");
                fullRow2 = true;
                Console.ReadLine();
                Console.Clear();
                gamePhase = 3;
            }
            else
            {
                Console.Clear();
            }
            break;

        case 3: //1 row plate 2
            if (plate2Array1.Contains(chosenNumber) && chosenNumber != 0)
            {
                newNumber = plate2Row1.IndexOf(chosenNumber);
                plate2Row1[newNumber] = -1;
            }
            else if (plate2Row2.Contains(chosenNumber) && chosenNumber != 0)
            {
                newNumber = plate2Row2.IndexOf(chosenNumber);
                plate2Row2[newNumber] = -1;
            }
            else if (plate2Row3.Contains(chosenNumber) && chosenNumber != 0)
            {
                newNumber = plate2Row3.IndexOf(chosenNumber);
                plate2Row3[newNumber] = -1;
            }

            plate2Array1 = plate2Row1.ToArray().Where(x => x != 0).ToArray();
            plate2Array2 = plate2Row2.ToArray().Where(x => x != 0).ToArray();
            plate2Array3 = plate2Row3.ToArray().Where(x => x != 0).ToArray();

            if (plate2Array1.AsQueryable().All(x => x == -1 && x != 0) ||
                plate2Array2.AsQueryable().All(x => x == -1 && x != 0) ||
                plate2Array3.AsQueryable().All(x => x == -1 && x != 0))
            {
                Console.WriteLine("2 full rows obtained!\n Click enter to continue!");
                fullRow2 = true;
                Console.ReadLine();
                Console.Clear();
                gamePhase = 4;
            }
            else
            {
                Console.Clear();
            }
            break;


        case 4: // Full plate on all plates to make it executable
            if (plate1Row1.Contains(chosenNumber) && chosenNumber != 0)
            {
                newNumber = plate1Row1.IndexOf(chosenNumber);
                plate1Row1[newNumber] = -1;
            }
            else if (plate1Row2.Contains(chosenNumber) && chosenNumber != 0)
            {
                newNumber = plate1Row2.IndexOf(chosenNumber);
                plate1Row2[newNumber] = -1;
            }
            else if (plate1Row3.Contains(chosenNumber) && chosenNumber != 0)
            {
                newNumber = plate1Row3.IndexOf(chosenNumber);
                plate1Row3[newNumber] = -1;
            }
            //plate 1 temp array
            plate1Array1 = plate1Row1.ToArray().Where(x => x != 0).ToArray();
            plate1Array2 = plate1Row2.ToArray().Where(x => x != 0).ToArray();
            plate1Array3 = plate1Row3.ToArray().Where(x => x != 0).ToArray();

            //Plate 2 temp array
            plate2Array1 = plate1Row1.ToArray().Where(x => x != 0).ToArray();
            plate2Array2 = plate1Row2.ToArray().Where(x => x != 0).ToArray();
            plate2Array3 = plate1Row3.ToArray().Where(x => x != 0).ToArray();

            //Plate 3 temp array
            plate3Array1 = plate1Row1.ToArray().Where(x => x != 0).ToArray();
            plate3Array2 = plate1Row2.ToArray().Where(x => x != 0).ToArray();
            plate3Array3 = plate1Row3.ToArray().Where(x => x != 0).ToArray();

            //If plate 1 is full
            if (plate1Array1.AsQueryable().All(x => x == -1 && x != 0) && 
                plate1Array2.AsQueryable().All(x => x == -1 && x != 0 && 
                plate1Array3.AsQueryable().All(x => x == -1 && x != 0)))
            {
                Console.WriteLine("FULL PLATE BITCHES!\n Click enter to continue!");
                fullRow3 = true;
                Console.ReadLine();
                Console.Clear();
                gamePhase = 5;
            }
            //If plate 2 is full
            if (plate2Array1.AsQueryable().All(x => x == -1 && x != 0) &&
                plate2Array2.AsQueryable().All(x => x == -1 && x != 0 &&
                plate2Array3.AsQueryable().All(x => x == -1 && x != 0)))
            {
                Console.WriteLine("FULL PLATE BITCHES!\n Click enter to continue!");
                fullRow3 = true;
                Console.ReadLine();
                Console.Clear();
                gamePhase = 5;
            }
            //If plate 3 is full
            if (plate3Array1.AsQueryable().All(x => x == -1 && x != 0) &&
                plate3Array2.AsQueryable().All(x => x == -1 && x != 0 &&
                plate3Array3.AsQueryable().All(x => x == -1 && x != 0)))
            {
                Console.WriteLine("FULL PLATE BITCHES!\n Click enter to continue!");
                fullRow3 = true;
                Console.ReadLine();
                Console.Clear();
                gamePhase = 5;
            }
            else
            {
                Console.Clear();
            }
            break;

    }
}
*/
