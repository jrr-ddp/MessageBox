using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBox
{
    public class ShortNotification
    {
        SN_Window shortNotification;


        public static int show(string Text)
        {
            return -1;
        }

        public static int showDialog()
        {
            return -1;
        }

        //public static string Show(string text)
        //{
        //    SN_Window shortNotification = new SN_Window(text);
        //    shortNotification.Show();
        //    return "1";
        //}

        //public static string showDialog(string text)
        //{
        //    SN_Window shortNotification = new SN_Window(text);
        //    shortNotification.ShowDialog();
        //    return "1";
        //}
    }
}
