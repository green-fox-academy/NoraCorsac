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

namespace FunctionToCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //  draw a red horizontal line to the canvas' middle.
            //  draw a green vertical line to the canvas' middle.
            int number = 300;
            int suchnumber = 0;
            FunctionToCenter(foxDraw, number, suchnumber);
        }

        public static void FunctionToCenter(FoxDraw foxDraw, int number, int suchnumber)
        {
            for (int i = 0; i < 300; i+=20)
            {
                foxDraw.StrokeColor(Colors.Cyan);
                foxDraw.DrawLine(suchnumber, suchnumber + i, 150, 150);
            }

            for (int i = 0; i < 300; i += 20)
            {
                foxDraw.StrokeColor(Colors.Cyan);
                foxDraw.DrawLine(number, number - i, 150, 150);
            }

            for (int i = 0; i < 300; i+=20)
            {
                foxDraw.StrokeColor(Colors.YellowGreen);
                foxDraw.DrawLine(suchnumber + i, number, 150, 150);
            }

            for (int i = 0; i < 300; i+=20)
            {
                foxDraw.StrokeColor(Colors.YellowGreen);
                foxDraw.DrawLine(number - i, suchnumber, 150, 150);
            }

           /* for (int i = 0; i < 11; i++)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(0 + (i * 20), 0, 100, 100);
                foxDraw.DrawLine(200, 0 + (i * 20), 100, 100);
                foxDraw.DrawLine(0, 0 + (i * 20), 100, 100);
                foxDraw.DrawLine(0 + (i * 20), 200, 100, 100);
            }*/
        }
    }
}
 