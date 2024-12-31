using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace FirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            
        }


        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set {
                boundText = value;
                // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
                // OnPropertyChanged("BoundText");
                OnPropertyChanged(); // Do not need to write the string bcuz of the CallerMemberName
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Set from code!";

        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}