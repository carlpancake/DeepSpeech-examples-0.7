using CommonServiceLocator;
using DeepSpeech.WPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DeepSpeechWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Window_Loaded(object sender, RoutedEventArgs e) =>
            DataContext = ServiceLocator.Current.GetInstance<MainWindowViewModel>();
        private void EXIT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void INCREASE_FONT_Click(object sender, RoutedEventArgs e)
        {
            txtResult.FontSize = txtResult.FontSize + 4;
        }

        private void DECREASE_FONT_Click(object sender, RoutedEventArgs e)
        {
            txtResult.FontSize = txtResult.FontSize - 4;
        }        
    }
}
