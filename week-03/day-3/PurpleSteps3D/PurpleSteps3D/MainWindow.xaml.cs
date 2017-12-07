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

namespace PurpleSteps3D
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]
            PurpleSteps3D(foxDraw);
        }
        public static void PurpleSteps3D(FoxDraw foxDraw)
        {
            {
                int x = 10;

                Random randomColor = new Random();
                for (int i = 0; i < 6; i++)
                {
                    foxDraw.FillColor(Colors.MediumPurple);
                    foxDraw.DrawRectangle(x * i, x * i, x * i, x * i);
                }
            }
        }
    }
}