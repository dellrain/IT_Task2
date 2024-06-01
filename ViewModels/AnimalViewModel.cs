using System.ComponentModel;
using WpfApplicationAnimals.Models;

namespace WpfApplicationAnimals.ViewModels;

public class AnimalViewModel : INotifyPropertyChanged
{
    public Animal _animal;

    public int Speed
    {
        get { return _animal.Speed; }
        set
        {
            if (_animal.Speed != value)
            {
                _animal.Speed = value;
                OnPropertyChanged("Speed");
            }
        }
    }

    private string _animalSound;

    public string AnimalSound
    {
        get { return _animalSound; }
        set
        {
            _animalSound = value;
            OnPropertyChanged("AnimalSound");
        }
    }

    public AnimalViewModel(Animal animal)
    {
        _animal = animal;
    }

    public void Move()
    {
        _animal.Move();
        OnPropertyChanged("Speed");
    }

    public void Stand()
    {
        _animal.Stand();
        OnPropertyChanged("Speed");
    }

    private bool _canClimb;

    public bool CanClimb
    {
        get { return _canClimb; }
        set
        {
            if (_canClimb != value)
            {
                _canClimb = value;
                OnPropertyChanged(nameof(CanClimb));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}