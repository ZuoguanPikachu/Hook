using Hook.Util;
using System.Windows;

namespace Hook
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MouseHook mouseHook = new(OnMouseActivity);
        }

        private void OnMouseActivity(MouseHook.Point point)
        {
            textBlock.Text = $"{point.x}, {point.y}";
        }
    }
}
