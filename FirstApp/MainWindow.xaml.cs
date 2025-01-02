using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace FirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("It was a success", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            MessageBoxResult result = MessageBox.Show("Do you agree?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) { 
                tbInfo.Text = "You agreed";
            } else
            {
                tbInfo.Text = "You disagreed";
            }
        }        
    }
}