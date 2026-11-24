public class RegularUser : User
{
    public override void ViewActivity()
    {
        Console.WriteLine("Regular user is viewing only their own activity.");
    }
}
