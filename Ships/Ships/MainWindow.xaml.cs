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

using Ships;
using ShipsLibrary;

namespace Ships
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Board myBoard = new Board(10,10);
        Board hitBoard = new Board(10,10);

        private class XY
        {
            public int x;
            public int y;
            public XY(int x, int y)
            {              
                this.x = x;
                this.y = y;
            }
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private XY ParseXY(string name)
        {
            int x, y;
            string coords = name.Substring(name.Length - 2);
            if(!int.TryParse(coords[0].ToString(), out y) || !int.TryParse(coords[1].ToString(), out x))
            {
                return null;
            }
            XY xy = new XY(x, y);
            return xy;
        }

        private void click_hit(object sender, MouseButtonEventArgs e)
        {
            if(!(sender is Rectangle)){
                return;
            }
            var senderRect = sender as Rectangle;
            var xy = ParseXY(senderRect.Name);
        }

        private void click_my(object sender, MouseButtonEventArgs e)
        {
            if (!(sender is Rectangle))
            {
                return;
            }
            var senderRect = sender as Rectangle;
            var xy = ParseXY(senderRect.Name);


        }
    }
}
