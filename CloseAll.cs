using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MessageBox
{
    public class CloseAll
    {
        public static void AllShortNotifications()
        {
            foreach (SN_Window window in Application.Current.Windows.OfType<SN_Window>())
                window.QuickClose();

            while(Application.Current.Windows.OfType<SN_Window>().Count() > 0)
            {

            }
        }

        public static void AllMessageBoxes()
        {
            foreach (MB_Window window in Application.Current.Windows.OfType<MB_Window>())
                window.Close();

            while (Application.Current.Windows.OfType<MB_Window>().Count() > 0)
            {

            }
        }

        public static void AllMessages()
        {
            AllShortNotifications();
            AllMessageBoxes();
        }
    }
}
