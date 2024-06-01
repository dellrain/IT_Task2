namespace WpfApplicationAnimals.Models;

public class Dog : Animal
{
    public event EventHandler<EventArgs> VoiceEvent;

    public override void Move()
    {
        Speed = Math.Min(Speed + 5, 100);
    }

    public override void Stand()
    {
        Speed = Math.Max(Speed - 5, 0);
    }

    public void MakeVoice()
    {
        VoiceEvent?.Invoke(this, EventArgs.Empty);
    }
}