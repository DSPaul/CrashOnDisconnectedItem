using System.Windows;
using System.Windows.Controls;

namespace CrashOnDisconnectedItem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainViewModel();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                btn.ContextMenu!.PlacementTarget = btn;
                btn.ContextMenu!.IsOpen = !btn.ContextMenu!.IsOpen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "crash", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}