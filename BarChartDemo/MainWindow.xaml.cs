using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BarChartDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DrawBar(150, 20);
            DrawBar(175, 70);
            DrawBar(120, 120);
            DrawBar(130, 170);
        }

        private void DrawBar(int width, int marginTop)
        {
            Rectangle r = new Rectangle();
            r.Width = width;
            r.Height = 30;
            r.Margin = new Thickness(20, marginTop, 0, 0);
            r.Stroke = new SolidColorBrush(Colors.Black);
            r.Fill = new SolidColorBrush(Color.FromArgb(127, 255, 0, 0));
            canvas.Children.Add(r);
        }
    }
}
