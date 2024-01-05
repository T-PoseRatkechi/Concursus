using CommunityToolkit.Mvvm.ComponentModel;
using Concursus.Library.Games;

namespace Concursus.Desktop.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private Game currentGame = new("p5t")
    {
        Name = "Persona 5 Tactica",
    };

    public MainWindowViewModel()
    {
        
    }

    public ViewModelBase Home { get; set; } = new ModsViewModel();

    public ViewModelBase Mods { get; set; } = new ModsViewModel();

    public ViewModelBase Settings { get; set; } = new SettingsViewModel();
}