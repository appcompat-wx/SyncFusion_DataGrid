using System.Windows;
using Syncfusion.SfSkinManager;

namespace SampleSFDataGridApplication;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private bool _isDarkTheme = false;
    public MainWindow()
    {
        InitializeComponent();
        SfSkinManager.SetTheme(this, new Theme("Windows11Light"));
    }

    private void ThemeToggleButton_Click(object sender, RoutedEventArgs e)
    {
        _isDarkTheme = !_isDarkTheme;
        string newTheme = _isDarkTheme ? "Windows11Dark" : "Windows11Light";

        SfSkinManager.SetTheme(this, new Theme(newTheme));

        ThemeToggleButton.Content = _isDarkTheme ? "Switch to Light Mode" : "Switch to Dark Mode";
    }
}