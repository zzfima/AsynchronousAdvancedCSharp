using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo5BlockedTask
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = "waiting";
            await DelayAsync();
            txt.Text = "waiting complete";
        }

        async Task DelayAsync()
        {
            try
            {
                await Task.Delay(1000);
                await Task.FromException(new Exception(""));
            }
            catch when (DateTime.Now.Minute < 30)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}