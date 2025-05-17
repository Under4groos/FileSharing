using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using FileSharing.Models;

namespace FileSharing.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly Random _random = new Random();
    
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
    
    [ObservableProperty] 
    private ObservableCollection<ChatModel> _chats;
    
    [ObservableProperty] 
    private ChatModel _selectedChat;
    
    public MainViewModel()
    {
        _chats ??= [];
    }
    
}
