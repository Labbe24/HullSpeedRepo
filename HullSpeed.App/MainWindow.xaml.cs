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

namespace HullSpeed.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Sailboat boat1 = null;
        public MainWindow()
        {
            InitializeComponent();

            boat1 = new Sailboat();

            Loaded += new RoutedEventHandler(MainWindow_Loaded);

        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Keyboard.Focus(TxtName);
        }

        private void NameTextChanged(object sender, TextChangedEventArgs e)
        {
           boat1.Name = TxtName.Text;
        }

        private void LengthTextChanged(object sender, TextChangedEventArgs e)
        {
            boat1.Length = double.Parse(TxtLength.Text);
        }

        private void calcHullspeedBtn_Click(object sender, RoutedEventArgs e)
        {
            TxtHullspeed.Text = boat1.Hullspeed().ToString("F1");
        }
    }
}
