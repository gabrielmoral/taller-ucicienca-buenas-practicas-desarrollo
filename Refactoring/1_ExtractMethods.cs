public void PrintOwing()
{
    PrintBanner();

    //print details
    Console.WriteLine("name: " + name);
    Console.WriteLine("amount: " + GetOutstanding());
}





public void PrintOwing()
{
    PrintBanner();
    PrintDetails(GetOutstanding());
}

private void PrintDetails(double outstanding)
{
    Console.WriteLine("name: " + name);
    Console.WriteLine("amount: " + outstanding);
}