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

namespace Diagonals
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Diagonals(foxDraw);
            // draw the canvas' diagonals in green.

        }
        public static void Diagonals(FoxDraw foxDraw)
        {
            {
                foxDraw.StrokeColor(Colors.Pink);
                foxDraw.DrawLine(0, 0, 525, 350);

                foxDraw.StrokeColor(Colors.LimeGreen);
                foxDraw.DrawLine(525, 0, 0, 350);
            }
        }
    }
}