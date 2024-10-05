using System.Windows;

namespace Hemuppgift_WPFtemplate.Pages
{

    public partial class StackPanel : Window
    {
        public StackPanel()
        {
            InitializeComponent();
        }

        private void Horizontal_Click(object sender, RoutedEventArgs e)
        {
            StackPanelX.Orientation = System.Windows.Controls.Orientation.Horizontal;
        }

        private void Vertical_Click(object sender, RoutedEventArgs e)
        {
            StackPanelX.Orientation = System.Windows.Controls.Orientation.Vertical;
        }
    }
}
