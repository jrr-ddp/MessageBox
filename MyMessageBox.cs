using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Effects;

namespace MessageBox
{
    public class MyMessageBox
    {
        public enum Buttons
        {
            Yes_No,
            Ok
        }

        public static string show(string Text)
        {
            return show(Text, Buttons.Ok);
        }

        public static string show(string Text, Buttons buttons)
        {
            MB_Window messageBox = new MB_Window(Text, buttons);
            messageBox.Show();
            return messageBox.ReturnString;
        }

        public static string showDialog(string Text)
        {
            return showDialog(Text, Buttons.Ok);
        }

        public static string showDialog(string Text, Buttons buttons)
        {
            BlurEffect();
            MB_Window messageBox = new MB_Window(Text, buttons);
            messageBox.ShowDialog();
            StopBlur();
            return messageBox.ReturnString;
        }

        static BlurEffect Blur = new BlurEffect();
        public static void BlurEffect()
        {
            Blur.Radius = 20;
            foreach (Window window in Application.Current.Windows)
                window.Effect = Blur;
        }

        public static void StopBlur()
        {
            Blur.Radius = 0;
        }
    }
}
