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
using GreenFox;

namespace CenteredSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a green 10x10 square to the canvas' center.
            Horizontal(foxDraw);

        }
        public static void Horizontal(FoxDraw foxDraw)
        {
            {
                foxDraw.StrokeColor(Colors.LightSeaGreen);
                foxDraw.DrawRectangle(255, 165, 10, 10);
            }
        }
    }
}
