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
    /// Interaction logic for Window_MB.xaml
    /// </summary>
    public partial class MB_Window : Window
    {
        public string ReturnString { get; set; }

        public MB_Window(string Text, MyMessageBox.Buttons buttons)
        {
            InitializeComponent();
            txtText.Text = Text;

            switch (buttons)
            {
                case MyMessageBox.Buttons.Ok:
                    btnOk.Visibility = Visibility.Visible;
                    break;
                case MyMessageBox.Buttons.Yes_No:
                    btnYes.Visibility = Visibility.Visible;
                    btnNo.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void Gbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch
            {

            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            ReturnString = "-1";
            Close();
        }

        DoubleAnimation anim;
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Closing -= Window_Closing;
            e.Cancel = true;
            anim = new DoubleAnimation(0, (Duration)TimeSpan.FromSeconds(0.3));
            anim.Completed += (s, _) => this.Close();
            this.BeginAnimation(UIElement.OpacityProperty, anim);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Height = (txtText.LineCount *27) + Gbar.Height + 50;
        }

        private void btnReturnValue_Click(object sender, RoutedEventArgs e)
        {
            ReturnString = ((Button)sender).Uid.ToString();
            Close();
        }
    }
}
