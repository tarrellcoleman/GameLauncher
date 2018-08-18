using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Interop;
using System.Windows;

namespace GameLauncher_v001
{
    
    public class ExtractLogo
    {
        public static Dictionary<string, ImageSource> listOfFiles = 
            new Dictionary<string, ImageSource>();
        public static bool isError;

        public static void ExtractFiles(string stringDir)
        {
            LauncherWindow lWin = new LauncherWindow();
            try
            {
                foreach(string dir in Directory.GetDirectories(stringDir))
                {
                        foreach (string file in Directory.GetFiles(dir, "*.exe"))
                        {
                            var icon = (Icon)null;
                            icon = Icon.ExtractAssociatedIcon(file);

                        Bitmap bitmap = icon.ToBitmap();
                        IntPtr hBitmap = bitmap.GetHbitmap();

                        ImageSource image = Imaging.CreateBitmapSourceFromHBitmap(
                            hBitmap,
                            IntPtr.Zero,
                            Int32Rect.Empty,
                            BitmapSizeOptions.FromEmptyOptions());

                            listOfFiles.Add(file, image);
                        }
                }

                isError = false;
            }
            catch(Exception excpt)
            {
                isError = true;
                MessageBox.Show(excpt.Message, "Error");
            }
        }

    }
}
