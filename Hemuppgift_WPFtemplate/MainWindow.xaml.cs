using Hemuppgift_WPFtemplate.Pages;
using System.Windows;

namespace Hemuppgift_WPFtemplate
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GridWindow_Click(object sender, RoutedEventArgs e)
        {
            GridWin grid = new Pages.GridWin();
            grid.Show();

        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Show();
        }
        private void WrapPanel_Click(object sender, RoutedEventArgs e)
        {
            WrapPanel wrapPanel = new WrapPanel();
            wrapPanel.Show();
        }
        private void DockPanel_Click(object sender, RoutedEventArgs e)
        {
            DeckPanel deckPanel = new DeckPanel();
            deckPanel.Show();
        }
    }
}