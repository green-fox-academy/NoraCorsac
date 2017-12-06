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

namespace RainbowBoxes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int x = 10;

            RainbowBoxes(foxDraw, x);
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.

        }
    }
        public static void RainbowBoxes(FoxDraw foxDraw, int x, Random RandomColor)
        {
            Color[] mycolor = { Colors.MediumPurple, Colors.Purple, Colors.Blue, Colors.LightGreen, Colors.Yellow, Colors.Orange, Colors.Red};

            for (int i = 0; i < 5; i++)
            {
                foxDraw.FillColor(mycolor);
                foxDraw.DrawRectangle(255, 165, x, x);
            }
        }
}