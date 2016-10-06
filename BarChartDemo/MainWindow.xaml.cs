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
            Rectangle r1 = new Rectangle();
            r1.Width = 150;
            r1.Height = 30;
            r1.Margin = new Thickness(20, 20, 0, 0);
            r1.Stroke = new SolidColorBrush(Colors.Black);
            r1.Fill = new SolidColorBrush(Color.FromArgb(127,255,0,0));
            canvas.Children.Add(r1);

            Rectangle r2 = new Rectangle();
            r2.Width = 175;
            r2.Height = 30;
            r2.Margin = new Thickness(20, 70, 0, 0);
            r2.Stroke = new SolidColorBrush(Colors.Black);
            r2.Fill = new SolidColorBrush(Color.FromArgb(127, 255, 0, 0));
            canvas.Children.Add(r2);

            Rectangle r3 = new Rectangle();
            r3.Width = 120;
            r3.Height = 30;
            r3.Margin = new Thickness(20, 120, 0, 0);
            r3.Stroke = new SolidColorBrush(Colors.Black);
            r3.Fill = new SolidColorBrush(Color.FromArgb(127, 255, 0, 0));
            canvas.Children.Add(r3);
        }
    }
}
