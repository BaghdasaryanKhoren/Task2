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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int pt1X, pt1Y, pt2X, pt2Y, pt3X, pt3Y;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myGrid.Children.Clear();
            pt1X = Convert.ToInt32(point1X.Text);
            pt1Y = Convert.ToInt32(point1Y.Text);
            pt2X = Convert.ToInt32(point2X.Text);
            pt2Y = Convert.ToInt32(point2Y.Text);
            pt3X = Convert.ToInt32(point3X.Text);
            pt3Y = Convert.ToInt32(point3Y.Text);
            point1X.Clear();
            point1Y.Clear();
            point2X.Clear();
            point2Y.Clear();
            point3X.Clear();
            point3Y.Clear();
            Polygon polygon = new Polygon();
            polygon.Stroke = System.Windows.Media.Brushes.Black;
            polygon.StrokeThickness = 3;
            Point point1 = new Point(pt1X, pt1Y);
            Point point2 = new Point(pt2X, pt2Y);
            Point point3 = new Point(pt3X, pt3Y);
            PointCollection points = new PointCollection();
            points.Add(point1);
            points.Add(point2);
            points.Add(point3);
            polygon.Points = points;
            
            myGrid.Children.Add(polygon);
            
        }
    }
}
