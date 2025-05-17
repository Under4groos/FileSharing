using System;
using System.Collections.ObjectModel;
using FileSharing.ViewModels;

namespace FileSharing.Models;

public class ChatModel : ViewModelBase
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int Count { get; set; }

    public string? Src { get; set; } = "https://i.pinimg.com/736x/1a/e8/78/1ae8782f9753ef51c7a51bf697b1a980.jpg";

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Count: {Count}, Src: {Src}";
    }
}