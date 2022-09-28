
using DiamondShapes;
using System.Text;

Console.Write("Enter alphabet :");
char alphabet = Console.ReadKey().KeyChar;
IPrintShapes printShapes = new PrintShapes();

while (printShapes.ShowValidationMessage(alphabet) != alphabet.ToString())
{
    Console.Write("\n" + "Please enter only alphabet:");
    alphabet = Console.ReadKey().KeyChar;
}

string str = printShapes.PrintDiamond(alphabet);
Console.WriteLine(str.ToString());
Console.ReadKey();

