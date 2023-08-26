int score = 65;

if (88 <= score && score <= 100)
{
    Console.WriteLine("Success - AA");
}
else if (81 <= score && score < 88)
{
    Console.WriteLine("Success - BA");
}
else if (74 <= score && score < 81)
{
    Console.WriteLine("Success - BB");
}
else if (67 <= score && score < 74)
{
    Console.WriteLine("Success - CB");
}
else if (60 <= score && score < 67)
{
    Console.WriteLine("Success - CC");
}
else if (0 <= score && score < 60)
{
    Console.WriteLine("Fail - FF");
}
else
{
    Console.WriteLine("Invalid Score");
}






string command = "wait";

    
switch (command)
{
    case "start":
        Console.WriteLine("Game is starting");
        break;
    case "stop":
        Console.WriteLine("Game stopped");
        break;
    case "wait":
        Console.WriteLine("Game paused");
        break;

        default:
        Console.WriteLine("Command not found");
        break;
}





