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
            DrawLine(foxDraw, 165, 125, 180, 125);
            double startX = 165;
            double startY = 125;
           /* DrawLine(startX, startY);*/
        }

        public static void DrawLine(FoxDraw foxDraw, double startX, double startY, double size, int levels)
        {
            if (levels == 0)
            {
                return;
            }
            for (int i = 0; i < 61; i+= 15)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(startX, startY, startX + i, startY);
                foxDraw.DrawLine(startX + i, startY, startX + i + (i / 2), startY - i);
                foxDraw.DrawLine(startX + i + (i / 2), startY - i, startX + (i * 2), startY);
                foxDraw.DrawLine(startX + (i * 2), startY, startX + (i * 3), startY);
            }
            

            /*for (int i = 0; i < 5; i++)
            {
                foxDraw.DrawLine(startingX, startingY, startingX + size, startingY);
                foxDraw.DrawLine(startingX, startingY, startingX + (size / 2), startingY + (size / 2) * Math.Sqrt(3));
                foxDraw.DrawLine(startingX + (size / 2), startingY + (size / 2) * Math.Sqrt(3), startingX + size, startingY);
                
                DrawLine(foxDraw, startingX, startingY, size / 2, levels - 1);

            }
                DrawLine(foxDraw, startingX + (size / 4), startingY + (size / 4) * Math.Sqrt(3), size / 2, levels - 1);
                DrawLine(foxDraw, startingX + size / 2, startingY, size / 2, levels - 1);*/
            
        }
    }
}
