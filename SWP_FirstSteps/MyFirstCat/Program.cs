using MyFirstCat;
using System.Runtime.InteropServices.JavaScript;
using static System.Runtime.InteropServices.JavaScript.JSType;

Cat myCat = new Cat(new DateTime(1800, 8, 14)); //erstellt eine Instanz der Klasse Cat und weißt sie der Variable mit dem Namen myCat zu
myCat.Color = "black";
Console.WriteLine($"The color of my Cat is {myCat.Color} and is {myCat.Age} years old");