using WpfApplicationAnimals.Models;

namespace WpfApplicationAnimals.ViewModels;

public class TurtleViewModel : AnimalViewModel
{
    public TurtleViewModel() : base(new Turtle())
    {
    }
    
    public TurtleViewModel(Turtle turtle) : base(turtle)
    {
    }
}