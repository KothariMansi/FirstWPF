using System.Collections;
using System.Collections.ObjectModel;
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
            entries = new ObservableCollection<string>();
            InitializeComponent();
        }

        private ObservableCollection<string> entries; 

        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtEntry.Text != "") {
                Entries.Add(txtEntry.Text);
                txtEntry.Clear();
                txtEntry.Focus();
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Entries.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            string item = (string)lvEntries.SelectedItem;
            Entries.Remove(item);
        }
    }
}