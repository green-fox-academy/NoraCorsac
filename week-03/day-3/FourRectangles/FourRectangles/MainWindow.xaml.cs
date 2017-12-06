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

namespace FourRectangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

           //BackColor = randomColor
            
            FourRectangles(foxDraw);
            // draw four different size and color rectangles.

        }
        public static void FourRectangles(FoxDraw foxDraw)
        {
            {
                int x = 10;
                int y = 40;

                Random randomColor = new Random();
                for (int i = 0; i < 5; i++)
                                    {
                    foxDraw.FillColor(Color.FromRgb((byte)randomColor.Next(), (byte)randomColor.Next(), (byte)randomColor.Next()));
                    foxDraw.DrawRectangle(x * i, y * i, 20 * i, 20 * i);
                }                
            }
        }
    }
}