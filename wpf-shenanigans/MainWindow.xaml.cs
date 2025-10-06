using System;
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

namespace wpf_shenanigans
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double positionX = 0;
        private double positionY = 0;

        public MainWindow()
        {
            InitializeComponent();
            RedRectangle.MouseDown += new MouseButtonEventHandler(RedRectangle_MainGrid_MouseDown);
        }

        // the idea is that you can grab a component on MouseDown and release it on MouseUp
        private void RedRectangle_MainGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            positionX = e.GetPosition(this).X;
            positionY = e.GetPosition(this).Y;

            Canvas.SetLeft(RedRectangle, positionX);
            Canvas.SetTop(RedRectangle, positionY);
        }
    }
}