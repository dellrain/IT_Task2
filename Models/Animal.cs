namespace WpfApplicationAnimals.Models;

public abstract class Animal
{
    public int Speed { get; set; }

    public abstract void Move();
    public abstract void Stand();
}