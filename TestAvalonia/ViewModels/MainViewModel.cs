using CommunityToolkit.Mvvm.ComponentModel;

namespace TestAvalonia.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string greeting = "Avalonia";
    }
}