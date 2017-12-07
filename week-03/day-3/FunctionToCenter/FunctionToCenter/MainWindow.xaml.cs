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
            int x = 10;
            int y = 35;
            FunctionToCenter(foxDraw, x, y);
        }

        public static void FunctionToCenter(FoxDraw foxDraw, int x, int y)
        {
            for (int i = 0; i < 10; i = 20)
            {
                foxDraw.StrokeColor(Colors.Cyan);
                foxDraw.DrawLine(x + i, y + i, 350, 175);
            }
        }
    }
}
