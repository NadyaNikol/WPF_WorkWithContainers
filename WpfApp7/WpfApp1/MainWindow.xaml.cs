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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button button1 = new Button { Content = "Button1" };
            Button button2 = new Button { Content = "Button2" };
            Button button3 = new Button { Content = "Button3" };
            Button button4 = new Button { Content = "Button4" };
            Button button5 = new Button { Content = "Button5" };


            DockPanel1.Children.Add(button1);
            DockPanel1.Children.Add(button2);
            DockPanel1.Children.Add(button3);
            DockPanel1.Children.Add(button4);
            DockPanel1.Children.Add(button5);


            DockPanel.SetDock(button1, Dock.Top);
            DockPanel.SetDock(button2, Dock.Bottom);
            DockPanel.SetDock(button3, Dock.Left);
            DockPanel.SetDock(button4, Dock.Top);
            DockPanel.SetDock(button5, Dock.Top);
        }
    }
}
