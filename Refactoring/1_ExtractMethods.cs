void PrintOwing()
{
    PrintBanner();

    //print details
    Console.WriteLine("name: " + name);
    Console.WriteLine("amount: " + GetOutstanding());
}





void PrintOwing()
{
    PrintBanner();
    PrintDetails(GetOutstanding());
}

void PrintDetails(double outstanding)
{
    Console.WriteLine("name: " + name);
    Console.WriteLine("amount: " + outstanding);
}