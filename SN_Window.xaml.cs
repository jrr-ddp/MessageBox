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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MessageBox
{
    /// <summary>
    /// Interaction logic for SN_Window.xaml
    /// </summary>
    public partial class SN_Window : Window
    {
        public int Time = 8;

        public SN_Window(string Text)
        {
            InitializeComponent();
            txtText.Text = Text;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Height = (txtText.LineCount * 52) + 50;
            Close();
        }

        DoubleAnimation anim;
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Closing -= Window_Closing;
            e.Cancel = true;
            anim = new DoubleAnimation(0, (Duration)TimeSpan.FromSeconds(Time));
            anim.Completed += (s, _) => this.Close();
            this.BeginAnimation(UIElement.OpacityProperty, anim);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            QuickClose();
        }

        public void QuickClose()
        {
            anim = new DoubleAnimation(0, (Duration)TimeSpan.FromSeconds(0.1));
            anim.Completed += (s, _) => this.Close();
            this.BeginAnimation(UIElement.OpacityProperty, anim);
        }
    }
}
