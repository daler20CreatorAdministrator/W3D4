public abstract class Account
{
    public string UserName { get; set; }

    public void Login()
    {
        Console.WriteLine($"{UserName} logged in.");
    }
}