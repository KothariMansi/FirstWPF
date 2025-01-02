using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.Win32;

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
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "C# source file | *.cs| Pdf File | *.pdf";
            fileDialog.InitialDirectory = @"C:\Users\";
            fileDialog.Title = "Please select a .cs file";
            fileDialog.Multiselect = true;


            bool? success = fileDialog.ShowDialog();
            if (success == true)
            {
                string[] paths = fileDialog.FileNames;
                string[] fileNames = fileDialog.SafeFileNames;
                
            } else
            {

            }
        }        
    }
}