using CommunityToolkit.Mvvm.ComponentModel;

namespace Concursus.Library.Games;

public partial class Game : ObservableObject
{
    [ObservableProperty]
    private string? name = string.Empty;

    public Game(string internalName)
    {
        this.InternalName = internalName;
    }

    public string InternalName { get; }
}
