using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfResourceApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn.FontSize = 28;
            btn.Content = "Press me";

            btn.Foreground = this.TryFindResource("brushRed") as Brush;

            LinearGradientBrush grad = new();
            grad.GradientStops.Add(new(Colors.Pink, 0));
            grad.GradientStops.Add(new(Colors.Yellow, 1));

            this.Resources.Add("brushGrad", grad);
            btn.Background = this.TryFindResource("brushGrad") as Brush;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["brushRed"] = new SolidColorBrush(Colors.Blue);
        }
    }
}