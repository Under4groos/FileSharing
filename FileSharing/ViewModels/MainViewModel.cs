using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FileSharing.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
    
    
 
    [ObservableProperty]
    private ObservableCollection<string> _ips = [];
}
