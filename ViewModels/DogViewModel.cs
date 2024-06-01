using WpfApplicationAnimals.Models;

namespace WpfApplicationAnimals.ViewModels;

public class DogViewModel : AnimalViewModel
{
    public event EventHandler<EventArgs> VoiceEvent;

    public DogViewModel() : base(new Dog())
    {
    }
    
    public DogViewModel(Dog dog) : base(dog)
    {
        dog.VoiceEvent += (sender, args) => VoiceEvent?.Invoke(sender, args);
    }

    public void MakeVoice()
    {
        ((Dog)_animal).MakeVoice();
        AnimalSound = "Гав";
    }
}