using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ScrapePokerTwisters.App.Aplication.Helpers
{
    public static class WindowsInformationHelper
    {

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetWindowText(nint hWnd, StringBuilder strText, int maxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetWindowTextLength(nint hWnd);

        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc enumProc, nint lParam);

        // Delegate to filter which windows to include 
        public delegate bool EnumWindowsProc(nint hWnd, nint lParam);

        /// <summary> Get the text for the window pointed to by hWnd </summary>
        public static string GetWindowText(nint hWnd)
        {
            int size = GetWindowTextLength(hWnd);
            if (size > 0)
            {
                var builder = new StringBuilder(size + 1);
                GetWindowText(hWnd, builder, builder.Capacity);
                return builder.ToString();
            }

            return string.Empty;
        }

        /// <summary> Find all windows that match the given filter </summary>
        /// <param name="filter"> A delegate that returns true for windows
        ///    that should be returned and false for windows that should
        ///    not be returned </param>
        public static IEnumerable<KeyValuePair<string, nint>> FindWindows()//EnumWindowsProc filter)
        {
            nint found = nint.Zero;
            //List<IntPtr> windows = new List<IntPtr>();
            List<KeyValuePair<string, nint>> windows = new List<KeyValuePair<string, nint>>();

            EnumWindows(delegate (nint wnd, nint param)
            {
                //if (filter(wnd, param))
                //{
                // only add the windows that pass the filter
                //var w = GetWindowText(wnd);
                if (!string.IsNullOrWhiteSpace(GetWindowText(wnd)) && !GetWindowText(wnd).Contains(".NET") && !GetWindowText(wnd).Contains("GDI+")
                        && !GetWindowText(wnd).Contains("Hidden") && !GetWindowText(wnd).Contains("DDE") && !GetWindowText(wnd).Contains("System")
                        && !GetWindowText(wnd).Contains("Opera"))
                {
                    if (!windows.Any(x => x.Key == GetWindowText(wnd)))
                        windows.Add(new KeyValuePair<string, nint>(GetWindowText(wnd), wnd));
                }

                //}

                // but return true here so that we iterate all windows
                return true;
            }, nint.Zero);

            return windows;
        }

        /// <summary> Find all windows that contain the given title text </summary>
        /// <param name="titleText"> The text that the window title must contain. </param>
        //public static IEnumerable<IntPtr> FindWindowsWithText(string titleText)
        //{
        //    return FindWindows(delegate (IntPtr wnd, IntPtr param)
        //    {
        //        return GetWindowText(wnd).Contains(titleText);
        //    });
        //}
    }
}
