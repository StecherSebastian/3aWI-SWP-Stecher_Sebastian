/* Programmieraufgabe 5: (Arbeiten mit Strings)
 * Schreiben Sie eine Konsolenanwendung die einen String einliest
 * und die Anzahl an Selbstlauten (a, e, i, o, u) in dem String bestimmt und ausgibt.
 */
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Programmierauftrag_05 \n");

string? inputString = " ";
string outputString = " ";

int countA = 0;
int countE = 0;
int countI = 0;
int countO = 0;
int countU = 0;

while (!String.Equals(inputString, "Beenden", StringComparison.CurrentCultureIgnoreCase))
{
    Console.Write("Bitte gebe eine Zeichenkette ein: ");
    inputString = Console.ReadLine().ToLower();
    countUmlaute();
    Console.WriteLine($"Die Anzahl der jeweiligen Umlaute ist: \n a: {countA} \n e: {countE}\n i: {countI}\n o: {countO} \n u: {countU} \n Output der Variablen: {outputString}");
    variableReset();
}

void countUmlaute()
{
    for (int i = 0; i < inputString.Length; i++)
    {
        switch (inputString[i])
        {
            case 'a':
                countA++;
                outputString += inputString[i];
                break;
            case 'e':
                countE++;
                outputString += inputString[i];
                break;
            case 'i':
                countI++;
                outputString += inputString[i];
                break;
            case 'o':
                countO++;
                outputString += inputString[i];
                break;
            case 'u':
                countU++;
                outputString += inputString[i];
                break;
            default:
                outputString += ' ';
                break;
        }
    }
}

void variableReset()
{
    countA = 0;
    countE = 0;
    countI = 0;
    countO = 0;
    countU = 0;

    outputString = " ";
}