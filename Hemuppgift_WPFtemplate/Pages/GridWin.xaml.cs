using System.Windows;
using System.Windows.Controls;

namespace Hemuppgift_WPFtemplate.Pages
{
    /// <summary>
    /// Interaction logic for Grid.xaml
    /// </summary>
    public partial class GridWin : Window
    {
        public GridWin()
        {
            InitializeComponent();
        }



        private void ApplyPosition_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrEmpty(RowPosition.Text) && !string.IsNullOrEmpty(ColumnPosition.Text))
            {
                Button button = new Button();
                button.Content = $"Row: {RowPosition.Text}, Column: {ColumnPosition.Text}";

                int x = int.Parse(RowPosition.Text);
                int z = int.Parse(ColumnPosition.Text);


                Grid.SetColumn(button, x);
                Grid.SetRow(button, z);
                MainGrid.Children.Add(button);
                RowPosition.Clear();
                ColumnPosition.Clear();
            }
            else
            {
                MessageBox.Show("Write a Column and Row position.");
            }
        }
    }
}
