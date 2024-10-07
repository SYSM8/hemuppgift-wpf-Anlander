using System.Windows;

namespace Hemuppgift_WPFtemplate.Pages
{
    public partial class DeckPanel : Window
    {
        public DeckPanel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            img_trophy.Visibility = Visibility.Visible;
        }
    }
}
