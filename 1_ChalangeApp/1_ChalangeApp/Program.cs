// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
string myName = "Ewa";
bool isMen = false;
int myAge = 33;

if (isMen == false)
{
    if (myName == "Ewa" && myAge == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (myAge < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else Console.WriteLine("Kobieta powyżej 30 lat");

}
else if (myAge < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else Console.WriteLine("Pełnoletni mężczyzna");
