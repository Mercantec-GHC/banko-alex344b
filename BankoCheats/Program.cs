using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Runtime.InteropServices;

//creating lists and ids

List<int> plate1Row1 = new List<int> { 4, 0, 21, 0, 42, 0, 0, 71, 80 };
List<int> plate1Row2 = new List<int> { 6, 15, 0, 33, 0, 58, 0, 0, 82 };
List<int> plate1Row3 = new List<int> { 8, 17, 25, 0, 0, 0, 63, 75, 0 };

List<int> plate2Row1 = new List<int> { 2, 0, 24, 31, 44, 0, 0, 74, 0 };
List<int> plate2Row2 = new List<int> { 0, 0, 0, 0, 46, 52, 65, 77, 83 };
List<int> plate2Row3 = new List<int> { 9, 14, 29, 35, 0, 0, 0, 0, 89 };

List<int> plate3Row1 = new List<int> { 0, 0, 20, 0, 0, 52, 60, 72, 80 };
List<int> plate3Row2 = new List<int> { 6, 15, 27, 0, 46, 0, 0, 0, 82 };
List<int> plate3Row3 = new List<int> { 0, 18, 0, 37, 0, 58, 69, 75, 0 };

//Her laver vi  noget code som skal kunne opbevare et trukket nummer.
int choosenNumber = 0;

int newNumber;

bool fullRow1 =  false;
bool fullRow2 =  false;
bool fullRow3 =  false;

// her starter vi "fase 1 " en fuld række;

int gamePhase = 1;
while (true)
{
    //viser nuværende stadie af spillet
    for (int i = 0; i < 9; i++)
    {
        Console.Write(plate1Row1[i] == -1 ? "X " : plate1Row1[i] + " ");
    }
    Console.WriteLine();
    for(int i = 0; i < 9; i++)
    {
        Console.Write(plate1Row2[i] == -1 ? "X " : plate1Row2[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < 9; i++)
    {
        Console.Write(plate1Row3[i] == -1 ? "X " : plate1Row3[i] + " ");
    }
    Console.WriteLine();

    //få det valgte nummer og input
    choosenNumber = int.Parse(Console.ReadLine()); // converter til int

    //updater spilstadie baseret på input
    switch (gamePhase)
    {
        case 1: // en fuld række på første række
            if (plate1Row1.Contains(choosenNumber) && choosenNumber != 0)
            {
                newNumber = plate1Row1.IndexOf(choosenNumber);
                plate1Row1[newNumber] = -1;
            }
            else if (plate1Row2.Contains(choosenNumber) && choosenNumber != 0)
            {
                newNumber = plate1Row2.IndexOf(choosenNumber);
                plate1Row2[newNumber] = -1;
            }
            else if (plate1Row3.Contains(choosenNumber) && choosenNumber != 0)
            {
                newNumber = plate1Row3.IndexOf(choosenNumber);
                plate1Row3[newNumber] = -1;
            }

            if (plate1Row1.All(x => x == -1 || x != 0) || 
                plate1Row2.All(x => x == -1 || x != 0) || 
                plate1Row3.All(x => x == -1 || x != 0))
            {
                Console.WriteLine("Du har en fuld række");
                fullRow1 = true;
                Console.ReadLine();
                Console.WriteLine("Fortsæt klik enter");
                Console.Clear();
                gamePhase = 2;
            }
            else
            {
                Console.Clear();
            }
            break;

        case 2: // 2 fulde rækker på første plade
            if (plate1Row1.Contains(choosenNumber) && choosenNumber != 0)
            {
                newNumber = plate1Row1.IndexOf(choosenNumber);
                plate1Row1[newNumber] = -1;
            }
            else if (plate1Row2.Contains(choosenNumber) && choosenNumber != 0)
            {
                newNumber = plate1Row2.IndexOf(choosenNumber);
                plate1Row2[newNumber] = -1;
            }
            else if (plate1Row3.Contains(choosenNumber) && choosenNumber != 0)
            {
                newNumber = plate1Row3.IndexOf(choosenNumber);
                plate1Row3[newNumber] = -1;
            }

            if ((plate1Row1.All(x => x == -1 || x != 0) && plate1Row2.All(x => x == -1 || x != 0)) ||
                (plate1Row2.All(x => x == -1 || x != 0) && plate1Row3.All(x => x == -1 || x != 0)) ||
                (plate1Row3.All(x => x == -1 || x != 0) && plate1Row1.All(x => x == -1 || x != 0)))
            {
                Console.WriteLine("Du har 2 fulde rækker");
                fullRow2 = true;
                Console.ReadLine();
                Console.WriteLine("Fortsæt klik enter");
                Console.Clear();
                gamePhase = 3;
            }
            else
            {
                Console.Clear();
            }
            break;

        case 3: // fuld plade på første plade
            if (plate1Row1.Contains(choosenNumber) && choosenNumber != 0)
            {
                newNumber = plate1Row1.IndexOf(choosenNumber);
                plate1Row1[newNumber] = -1;
            }
            else if (plate1Row2.Contains(choosenNumber) && choosenNumber != 0)
            {
                newNumber = plate1Row2.IndexOf(choosenNumber);
                plate1Row2[newNumber] = -1;
            }
            else if (plate1Row3.Contains(choosenNumber) && choosenNumber != 0)
            {
                newNumber = plate1Row3.IndexOf(choosenNumber);
                plate1Row3[newNumber] = -1;
            }

            if ((plate1Row1.All(x => x == -1 || x != 0) &&
                 plate1Row2.All(x => x == -1 || x != 0) && 
                 plate1Row3.All(x => x == -1 || x != 0)))
            {
                Console.WriteLine("DU HAR FULD PLADE BITCHES!");
                fullRow3 = true;
                Console.ReadLine();
                Console.WriteLine("Fortsæt klik enter");
                Console.Clear();
                gamePhase = 4;
            }
            else
            {
                Console.Clear();
            }
            break;

    }
}
