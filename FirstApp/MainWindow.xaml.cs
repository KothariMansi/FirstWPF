using System.Collections;
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
            InitializeComponent();
            lvEntries.Items.Add("BMW");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtEntry.Text != "")
            {
                lvEntries.Items.Add(txtEntry.Text);
                txtEntry.Clear();
                txtEntry.Focus();
            } else
            {
                MessageBox.Show("Please enter a value", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                txtEntry.Focus();
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {

            //int selectedIndex = lvEntries.SelectedIndex;
            //if (selectedIndex != -1)
            //{
            //    lvEntries.Items.RemoveAt(selectedIndex);
            //} else
            //{
            //    MessageBox.Show("Please select an item to delete", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}

            //object selectedItem = lvEntries.SelectedItem;
            //if (selectedItem != null)
            //{
            //    MessageBoxResult result = MessageBox.Show($"Are you Sure you want to delete: {(string)selectedItem}?", "Delete Item", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //    if (result == MessageBoxResult.Yes)
            //    {
            //        lvEntries.Items.Remove(selectedItem);
            //    }
            //} else
            //{
            //    MessageBox.Show("Please select an item to delete", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}

            var selectedItems = lvEntries.SelectedItems;//.Cast<object>().ToList();
            MessageBoxResult result = MessageBox.Show($"Are you Sure you want to delete: {selectedItems.Count}?", "Delete Item", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) {
                var itemsList = new ArrayList(selectedItems);
                foreach (var item in itemsList) {
                    lvEntries.Items.Remove(item);
                }
            }
            txtEntry.Focus();

        }
    }
}