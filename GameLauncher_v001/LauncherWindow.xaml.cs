using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace GameLauncher_v001
{
    /// <summary>
    /// Interaction logic for PopupWindow.xaml
    /// </summary>
    public partial class LauncherWindow : Window
    {
        public static Button btn;
        public static List<string> exeFile = new List<string>();

        public LauncherWindow()
        {
            InitializeComponent();

            btnClicked();
            
        }

        public void intoBtns()
        {
            int counter = 0;
            foreach (var game in ExtractLogo.listOfFiles)
            {
                exeFile.Add(game.Key);
                var brush = new ImageBrush();
                brush.ImageSource = game.Value;
                object tb = FindName("btnPlay" + counter.ToString());
                btn = (Button)tb;
                btn.Background = brush;
                btn.ToolTip = game.Key;
                counter++;
            }
        }

        public void btnClicked()
        {
            btnPlay0.Click += myEventHandler;
            btnPlay1.Click += myEventHandler;
            btnPlay2.Click += myEventHandler;
            btnPlay3.Click += myEventHandler;
            btnPlay4.Click += myEventHandler;
            btnPlay5.Click += myEventHandler;
            btnPlay6.Click += myEventHandler;
            btnPlay7.Click += myEventHandler;
            btnPlay8.Click += myEventHandler;
            btnPlay9.Click += myEventHandler;
        }

        public void myEventHandler(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Name;

            switch (buttonText)
            {
                case "btnPlay0":
                    Process.Start(exeFile.ElementAt(0));
                    break;
                case "btnPlay1":
                    Process.Start(exeFile.ElementAt(1));
                    break;
                case "btnPlay2":
                    Process.Start(exeFile.ElementAt(2));
                    break;
                case "btnPlay3":
                    Process.Start(exeFile.ElementAt(3));
                    break;
                case "btnPlay4":
                    Process.Start(exeFile.ElementAt(4));
                    break;
                case "btnPlay5":
                    Process.Start(exeFile.ElementAt(5));
                    break;
                case "btnPlay6":
                    Process.Start(exeFile.ElementAt(6));
                    break;
                case "btnPlay7":
                    Process.Start(exeFile.ElementAt(7));
                    break;
                case "btnPlay8":
                    Process.Start(exeFile.ElementAt(8));
                    break;
                case "btnPlay9":
                    Process.Start(exeFile.ElementAt(9));
                    break;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();

            main.Visibility = Visibility.Visible;

        }
    }
}
