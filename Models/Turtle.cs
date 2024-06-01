namespace WpfApplicationAnimals.Models;

public class Turtle : Animal
{
    public override void Move()
    {
        Speed = Math.Min(Speed + 1, 10);
    }

    public override void Stand()
    {
        Speed = Math.Max(Speed - 1, 0);
    }
}