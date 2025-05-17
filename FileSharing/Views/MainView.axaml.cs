using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;
using BeaconLib;
using FileSharing.ViewModels;

namespace FileSharing.Views;

public partial class MainView : UserControl
{
    private Beacon? beacon;
    private Probe? probe;

    public MainView()
    {
        InitializeComponent();

        //
        // if (OperatingSystem.IsWindows())
        // {
        //     probe = new Probe("myApp");
        //     probe.BeaconsUpdated += ProbeOnBeaconsUpdated;
        //     probe.Start();
        //
        // }
        //



    }

    private void ProbeOnBeaconsUpdated(IEnumerable<BeaconLocation> beacons)
    {
        // Dispatcher.UIThread.InvokeAsync(() =>
        // {
        //     if (this.DataContext is MainViewModel vm)
        //     {
        //         vm.Ips.Clear();
        //         foreach (var beacon in beacons)
        //         {
        //             vm.Ips.Add(beacon.Address.ToString());
        //             Debug.WriteLine(beacon.Address + ": " + beacon.Data);
        //         }   
        //   
        //     }
        // });
        
         
    }

    protected override void OnUnloaded(RoutedEventArgs e)
    {
        beacon?.Stop();
        base.OnUnloaded(e);
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        // if (OperatingSystem.IsAndroid())
        // {
        //     if(beacon is { Stopped: false })
        //         beacon.Dispose();
        //     beacon = new Beacon("myApp", 1234);
        //     beacon.Start();
        //
        //     Debug.WriteLine("Beacon");
        // }
        
        
    }
}