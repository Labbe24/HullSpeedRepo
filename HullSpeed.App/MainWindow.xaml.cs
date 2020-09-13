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
        Sailboat boat1;
        public MainWindow()
        {
            InitializeComponent();

            boat1 = new Sailboat();

            Loaded += new RoutedEventHandler(MainWindow_Loaded);
            KeyDown += new KeyEventHandler(MainWindow_KeyDown);

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

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.L:
                {
                    if (Keyboard.Modifiers == ModifierKeys.Control)
                    {
                        FontSize += 2;
                        e.Handled = true;
                    }
                    break;
                    }

                case Key.S:
                {
                    if ((Keyboard.Modifiers == ModifierKeys.Control) && FontSize>=6)
                    {
                        FontSize -= 2;
                        e.Handled = true;
                    }
                    break;
                }
            }
        }
    }
}
