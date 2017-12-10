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

namespace Snowflake
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int startX = 165;
            int startY = 125;
            int i = 15;
            FunctionToCenter(foxDraw, startX, startY, i);
        }

        public static void FunctionToCenter(FoxDraw foxDraw, int startX, int startY, int i)
        {
            /*for (int i = 0; i < 61; i+= 15)*/
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(startX, startY, startX + i, startY);
                foxDraw.DrawLine(startX + i, startY, startX + i + (i / 2), startY - i);
                foxDraw.DrawLine(startX + i + (i / 2), startY - i, startX + (i * 2), startY);
                foxDraw.DrawLine(startX + (i * 2), startY, startX + (i * 3), startY);
            }
        }
    }
}
