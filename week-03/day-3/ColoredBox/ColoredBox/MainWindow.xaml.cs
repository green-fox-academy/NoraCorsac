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

namespace ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            ColoredBox(foxDraw);
            // draw a box that has different colored lines on each edge.

        }

        public static void ColoredBox(FoxDraw foxDraw)
        {
            {
                foxDraw.StrokeColor(Colors.Pink);
                foxDraw.DrawLine(0, 0, 100, 0);

                foxDraw.StrokeColor(Colors.LimeGreen);
                foxDraw.DrawLine(100, 0, 100, 100);

                foxDraw.StrokeColor(Colors.CornflowerBlue);
                foxDraw.DrawLine(100, 100, 0, 100);

                foxDraw.StrokeColor(Colors.LightGoldenrodYellow);
                foxDraw.DrawLine(0, 100, 0, 0);
            }
        }
    }
}
