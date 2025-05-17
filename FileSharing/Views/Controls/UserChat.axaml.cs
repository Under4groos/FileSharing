using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using FileSharing.Models;

namespace FileSharing.Views.Controls;

public partial class UserChat : Button
{
     

     

    public static readonly StyledProperty<Guid> IdProperty =
        AvaloniaProperty.Register<UserChat, Guid>(
            nameof(Id), 
            Guid.NewGuid()); // Default value can be set as needed

    public Guid Id
    {
        get => GetValue(IdProperty);
        set => SetValue(IdProperty, value);
    }

    public static readonly StyledProperty<string?> ChatNameProperty =
        AvaloniaProperty.Register<UserChat, string?>(
            nameof(ChatName), 
            null); // Default value can be set as needed

    public string? ChatName
    {
        get => GetValue(ChatNameProperty);
        set => SetValue(ChatNameProperty, value);
    }

    public static readonly StyledProperty<int> CountProperty =
        AvaloniaProperty.Register<UserChat, int>(
            nameof(Count), 
            0); // Default value can be set as needed

    public int Count
    {
        get => GetValue(CountProperty);
        set => SetValue(CountProperty, value);
    }
    
    public UserChat()
    {
        InitializeComponent();
        
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        Debug.WriteLine("Loaded");
        base.OnLoaded(e);
    }
}