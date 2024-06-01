using System.Windows;
using WpfApplicationAnimals.ViewModels;

namespace WpfApplicationAnimals.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void DogMove_Click(object sender, RoutedEventArgs e)
    {
        ((DogViewModel)Resources["DogViewModel"]).Move();
    }

    private void DogStand_Click(object sender, RoutedEventArgs e)
    {
        ((DogViewModel)Resources["DogViewModel"]).Stand();
    }

    private void DogMakeVoice_Click(object sender, RoutedEventArgs e)
    {
        ((DogViewModel)Resources["DogViewModel"]).MakeVoice();
    }
    
    private void PantherMove_Click(object sender, RoutedEventArgs e)
    {
        ((PantherViewModel)Resources["PantherViewModel"]).Move();
    }

    private void PantherStand_Click(object sender, RoutedEventArgs e)
    {
        ((PantherViewModel)Resources["PantherViewModel"]).Stand();
    }

    private void PantherMakeVoice_Click(object sender, RoutedEventArgs e)
    {
        ((PantherViewModel)Resources["PantherViewModel"]).MakeVoice();
    }
    
    private void PantherClimbTree_Click(object sender, RoutedEventArgs e)
    {
        ((PantherViewModel)Resources["PantherViewModel"]).ClimbTree();
    }
    
    private void TurtleMove_Click(object sender, RoutedEventArgs e)
    {
        ((TurtleViewModel)Resources["TurtleViewModel"]).Move();
    }

    private void TurtleStand_Click(object sender, RoutedEventArgs e)
    {
        ((TurtleViewModel)Resources["TurtleViewModel"]).Stand();
    }

}