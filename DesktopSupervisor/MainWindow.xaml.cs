using DesktopSupervisor.Models;
using DesktopSupervisor.Supervisor;
using Microsoft.Web.WebView2.Core;
using System;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace DesktopSupervisor;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Loaded += OnLoaded;
    }

    private async void OnLoaded(object sender, RoutedEventArgs e)
    {
        await WebView.EnsureCoreWebView2Async();

        WebView.CoreWebView2.Settings.AreDevToolsEnabled = true;
        WebView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;

        WebView.CoreWebView2.WebMessageReceived += OnWebMessageReceived;

        var htmlPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "web",
            "index.html"
        );

        WebView.Source = new Uri(htmlPath);
    }

    private void OnWebMessageReceived(object? sender, CoreWebView2WebMessageReceivedEventArgs e)
    {
        var command = JsonSerializer.Deserialize<QPointCommand>(e.WebMessageAsJson);

        if (command is null) return;

        var result = CommandProcessor.Process(command);

        SendToWeb(result);
    }

    private void SendToWeb(string message)
    {
        WebView.CoreWebView2.ExecuteScriptAsync(
            $"window.receiveFromSupervisor({JsonSerializer.Serialize(message)})"
        );
    }
}
