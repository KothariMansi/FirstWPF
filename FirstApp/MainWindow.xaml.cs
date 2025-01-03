using System.Windows;
using Winforms = System.Windows.Forms;

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
            Winforms.FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.InitialDirectory = @"C:\Users\SHREE";
            Winforms.DialogResult result = dialog.ShowDialog();
            if (result == Winforms.DialogResult.OK)
            {
                tbInfo.Text = dialog.SelectedPath;
            }
        }        
    }
}