//https://www.youtube.com/watch?v=lh8cT6qI-nA&ab_channel=DotNext

using System.Diagnostics;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click1(object sender, RoutedEventArgs e)
        {
            printDebug("Button_Click1 start");
            await Task.Run(WaitAsync);
            printDebug("Button_Click1 finish");
        }

        private async void Button_Click2(object sender, RoutedEventArgs e)
        {
            printDebug("Button_Click2 start");
            await WaitAsync();
            printDebug("Button_Click2 finish");
        }

        private async Task WaitAsync()
        {
            printDebug("WaitAsync start");
            await Task.Delay(5000);
            printDebug("WaitAsync finish");
        }

        private void printDebug(string title)
        {
            Debug.WriteLine("***********************");
            Debug.WriteLine(title);
            Debug.WriteLine("ManagedThreadId: " + Thread.CurrentThread.ManagedThreadId);
            Debug.WriteLine("Task.CurrentId: " + Task.CurrentId);
            Debug.WriteLine("SynchronizationContext: " + SynchronizationContext.Current?.ToString());
            Debug.WriteLine("***********************");
        }
    }
}