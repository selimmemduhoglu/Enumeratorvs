
//Create Custom Exception Class

try
{
    while (true)
    {
        var a = Console.ReadKey();
        if (a.Key == ConsoleKey.P)
        {
            throw new Exception("szasdasdasd");

        }
    }
    


}
catch (Exception ex)
{

}
class CustomException : Exception
{
    public CustomException() : base("Custom hata ....")
    {

    }
    public CustomException(string message) : base(message)
    {

    }

}

