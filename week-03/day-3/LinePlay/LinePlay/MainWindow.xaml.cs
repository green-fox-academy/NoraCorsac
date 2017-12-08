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

namespace LinePlay
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double number = 300;
            double suchnumber = 0;
            LinePlay(foxDraw, number, suchnumber);
        }

        public static void LinePlay(FoxDraw foxDraw, double number, double suchnumber)
        {
            for (int i = 0; i < 300; i+=20)
            {
                foxDraw.StrokeColor(Colors.LimeGreen);
                foxDraw.DrawLine(suchnumber, suchnumber + i, 150, 150);
                foxDraw.DrawLine(suchnumber + i, number, 150, 150);
            }
            for (int i = 0; i < 300; i += 20)
            {
                foxDraw.StrokeColor(Colors.MediumPurple);
                foxDraw.DrawLine(number, number - i, 150, 150);
                foxDraw.DrawLine(number - i, suchnumber, 150, 150);
            }   
        }
    }
}
