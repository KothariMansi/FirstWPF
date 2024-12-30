using System.Windows;

namespace FirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {
            running = !running;
            if (running) {
                tbStatus.Text = "Running....";
                btnToggleRun.Content = "Stop";
            } else
            {
                tbStatus.Text = "";
                btnToggleRun.Content = "Run";
            }
           
        }
    }
}