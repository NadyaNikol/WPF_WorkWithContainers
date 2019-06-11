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

namespace WpfApp2C
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid1.ColumnDefinitions.Add(new ColumnDefinition());
            Grid1.ColumnDefinitions.Add(new ColumnDefinition());
            Grid1.ColumnDefinitions.Add(new ColumnDefinition());

            Grid1.RowDefinitions.Add(new RowDefinition());
            Grid1.RowDefinitions.Add(new RowDefinition());
            Grid1.RowDefinitions.Add(new RowDefinition());



            Button button1 = new Button { Content = 1 };
            Button button2 = new Button { Content = 2 };
            Button button3 = new Button { Content = 3 };
            Button button4 = new Button { Content = 4 };
            Button button5 = new Button { Content = 5 };


            Grid.SetColumnSpan(button1, 2);

            Grid.SetColumn(button2, 2);
            Grid.SetRowSpan(button2, 2);

            Grid.SetRow(button3, 1);

            Grid.SetRow(button4, 1);
            Grid.SetColumn(button4, 1);

            Grid.SetRow(button5, 2);
            Grid.SetColumnSpan(button5, 3);


            Grid1.Children.Add(button1);
            Grid1.Children.Add(button2);
            Grid1.Children.Add(button3);
            Grid1.Children.Add(button4);
            Grid1.Children.Add(button5);


        }
    }
}
