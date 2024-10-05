using System.Windows;

namespace Hemuppgift_WPFtemplate.Pages
{

    public partial class WrapPanel : Window
    {
        public WrapPanel()
        {
            InitializeComponent();
        }
        private void Horizontal_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelX.Orientation = System.Windows.Controls.Orientation.Horizontal;
        }

        private void Vertical_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelX.Orientation = System.Windows.Controls.Orientation.Vertical;
        }
    }
}
