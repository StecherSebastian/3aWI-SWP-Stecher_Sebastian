/* Erweitern Sie ihre Konsolenanwendung in der Art, dass nach dem Einlesen der Natürlichen Zahl eine Abfrage erscheint,
 * in der Sie eine Mathematische Operation auswählen können...
 * Dies kann zum Beispiel so ausschauen:
 * Geben Sie eine Zahl zwischen 1 und 3 ein um eine Mathematische Operation auszuwählen:
 * 1) Quadrat
 * 2) Wurzel
 * 3) Fakultät
 */
Console.WriteLine("\n Programmierauftrag_04");

string? userInputString = " ";
int userInputInt = 0;

while (!String.Equals(userInputString, "Beenden", StringComparison.CurrentCultureIgnoreCase))
{
    Console.Write("Bitte geben Sie eine Natürliche Zahl ein (oder Beenden um zu beenden):");
    userInputString = Console.ReadLine();
    if (int.TryParse(userInputString, out userInputInt))
    {
        Console.Write("Geben Sie eine Zahl zwischen 1 und 3 ein, um eine mathematische Operation für die vorher eingegebene Zahl zu wählen: \n 1) Quadrat \n 2) Wurzel \n 3) Fakultät \n Zahl: ");
        userInputString = Console.ReadLine();
        switch (userInputString)
        {
            case "1":
                userInputInt *= userInputInt;
                Console.WriteLine($"Quadrat der eingegebenen Zahl: {userInputInt}");
                break;
            case "2":
                userInputInt = (int)Math.Sqrt(userInputInt);
                Console.WriteLine($"Wurzel der eingegebenen Zahl: {userInputInt}");
                break;
            case "3":
                int userInputFakultaet = 1;
                for (int i = 2; i <= userInputInt; i++)
                {
                    userInputFakultaet = userInputFakultaet * i;
                }
                Console.WriteLine($"Fakultät der eingegebenen Zahl: {userInputFakultaet}");
                break;
        }
    }
}