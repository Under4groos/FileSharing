using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Avalonia.Controls;
using Avalonia.Input.GestureRecognizers;
using Avalonia.Interactivity;
using Avalonia.Threading;
using BeaconLib;
using FileSharing.Models;
using FileSharing.ViewModels;

namespace FileSharing.Views;

public partial class MainView : UserControl
{
    private readonly Random _random = new Random();

    public MainView()
    {
        InitializeComponent();
        
        
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        if (this.DataContext is MainViewModel vm)
        {
            vm.Chats =
            [
                new ChatModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Обсуждение технологий",
                    Count = _random.Next(0, 101),
                    Src = "https://i.pinimg.com/736x/36/f8/53/36f8535a72a54ccfe5a3e424d36458d7.jpg"
                },

                new ChatModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Кулинарные рецепты",
                    Count = _random.Next(0, 101),
                    Src = "https://i.pinimg.com/736x/cb/87/1e/cb871e4708cba30bbdc95b300abb9fab.jpg"
                    
                },

                new ChatModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Путешествия и приключения",
                    Count = _random.Next(0, 101) // Случайное количество сообщений от 0 до 100
                },

                new ChatModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Спорт и фитнес",
                    Count = _random.Next(0, 101) // Случайное количество сообщений от 0 до 100
                },

                new ChatModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Книги и литература",
                    Count = _random.Next(0, 101) // Случайное количество сообщений от 0 до 100
                }
            ];
            for (int i = 0; i < 65; i++)
            {
                vm.Chats.Add(new ChatModel
                {
                    Id = Guid.NewGuid(),
                    Name = "Рандом чат " + _random.Next(0, 101).ToString(),
                    Count = _random.Next(0, 101) // Случайное количество сообщений от 0 до 100
                });
            }
            
        }
        base.OnLoaded(e);
    }

    private void Button_Click(object? sender, RoutedEventArgs e)
    {
         
        var button = sender as Button;
        var chatItem = button?.CommandParameter;

        if (button?.DataContext is ChatModel chatModel && this.DataContext is MainViewModel vm)
        {
            vm.SelectedChat = chatModel;
            Debug.WriteLine($"{chatModel}");
        }
        
        
    }
}