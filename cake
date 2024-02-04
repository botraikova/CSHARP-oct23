
int width = int.Parse(Console.ReadLine());
int lenght  = int.Parse(Console.ReadLine());    


int totalPieces = width * lenght;

while (true)
{ 

string command = Console.ReadLine();
    if (command == "STOP")
    {
        break;
    }

    int currentPieces = int.Parse(command);
    totalPieces -= currentPieces;

    if (totalPieces <= 0)
    {
        break;
    }

}
if (totalPieces < 0)
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
    
}
else
{
    Console.WriteLine($"{totalPieces} pieces are left.");
}
