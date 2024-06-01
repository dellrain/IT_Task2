using WpfApplicationAnimals.Models;

namespace WpfApplicationAnimals.ViewModels;

public class PantherViewModel : AnimalViewModel
{
    public event EventHandler<EventArgs> VoiceEvent;
    public event EventHandler<EventArgs> ClimbEvent;

    public PantherViewModel() : base(new Panther())
    {
    }

    public PantherViewModel(Panther panther) : base(panther)
    {
        panther.VoiceEvent += (sender, args) => VoiceEvent?.Invoke(sender, args);
        panther.ClimbEvent += (sender, args) => ClimbEvent?.Invoke(sender, args);
    }

    public void ClimbTree()
    {
        CanClimb = ((Panther)_animal).ClimbTree();
    }

    public void MakeVoice()
    {
        ((Panther)_animal).MakeVoice();
        AnimalSound = "Ррррр";
    }
}