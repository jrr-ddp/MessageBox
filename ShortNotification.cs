using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Effects;

namespace MessageBox
{
    public class ShortNotification
    {
        public static string Show(string text)
        {
            SN_Window shortNotification = new SN_Window(text);
            shortNotification.Show();
            return "1";
        }

        public static string showDialog(string text)
        {
            BlurEffect();
            SN_Window shortNotification = new SN_Window(text);
            shortNotification.ShowDialog();
            StopBlur();
            return "1";
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
