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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameLauncher_v001
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string drive;
        public static string directory;
        public static bool getError;

        LauncherWindow lWin = new LauncherWindow();

        public MainWindow()
        {
            InitializeComponent();

            //lWin.Visibility = Visibility.Hidden;

            radioClicked();
            

        }

        public void radioClicked()
        {
            radioBtn0.Click += myEventHandler;
            radioBtn1.Click += myEventHandler;
            radioBtn2.Click += myEventHandler;
        }

        public void myEventHandler(object sender, EventArgs e)
        {
            string buttonText = ((RadioButton)sender).Name;

            switch (buttonText)
            {
                case "radioBtn0":
                    drive = @"C:\";
                    backBtn.Visibility = Visibility.Visible;

                    radioBtn0.Visibility = Visibility.Hidden;
                    radioBtn1.Visibility = Visibility.Hidden;
                    radioBtn2.Visibility = Visibility.Hidden;

                    isDirectoryLabel.Visibility = Visibility.Visible;
                    yesBtn.Visibility = Visibility.Visible;
                    noBtn.Visibility = Visibility.Visible;

                    pasteDirect.Text = string.Empty;
                    pasteDirect.Visibility = Visibility.Hidden;
                    submitBtn.Visibility = Visibility.Hidden;

                    break;

                case "radioBtn1":
                    drive = @"D:\";
                    backBtn.Visibility = Visibility.Visible;

                    radioBtn0.Visibility = Visibility.Hidden;
                    radioBtn1.Visibility = Visibility.Hidden;
                    radioBtn2.Visibility = Visibility.Hidden;

                    isDirectoryLabel.Visibility = Visibility.Visible;
                    yesBtn.Visibility = Visibility.Visible;
                    noBtn.Visibility = Visibility.Visible;

                    pasteDirect.Text = string.Empty;
                    pasteDirect.Visibility = Visibility.Hidden;
                    submitBtn.Visibility = Visibility.Hidden;

                    break;

                case "radioBtn2":
                    pasteDirect.Visibility = Visibility.Visible;
                    submitBtn.Visibility = Visibility.Visible;
                    pasteDirect.Focus();
                    pasteDirect.SelectAll();
                    break;
            }
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            directory = pasteDirect.Text;

            ExtractLogo.ExtractFiles(directory);
            getError = ExtractLogo.isError;
            if (!getError)
            {
                lWin.intoBtns();
                lWin.Visibility = Visibility.Visible;
                Close();
            }
            else
            {
                pasteDirect.Text = string.Empty;
                backBtn.Visibility = Visibility.Hidden;

                radioBtn0.Visibility = Visibility.Visible;
                radioBtn1.Visibility = Visibility.Visible;
                radioBtn2.Visibility = Visibility.Visible;

                isDirectoryLabel.Visibility = Visibility.Hidden;
                yesBtn.Visibility = Visibility.Hidden;
                noBtn.Visibility = Visibility.Hidden;

                pasteDirect.Visibility = Visibility.Hidden;
                submitBtn.Visibility = Visibility.Hidden;
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            backBtn.Visibility = Visibility.Hidden;

            radioBtn0.Visibility = Visibility.Visible;
            radioBtn1.Visibility = Visibility.Visible;
            radioBtn2.Visibility = Visibility.Visible;

            isDirectoryLabel.Visibility = Visibility.Hidden;
            yesBtn.Visibility = Visibility.Hidden;
            noBtn.Visibility = Visibility.Hidden;

            pasteDirect.Text = string.Empty;
            pasteDirect.Visibility = Visibility.Hidden;
            submitBtn.Visibility = Visibility.Hidden;
        }

        private void yesBtn_Click(object sender, RoutedEventArgs e)
        {
            directory = drive + @"SteamLibrary\steamapps\common\";
            ExtractLogo.ExtractFiles(directory);
            getError = ExtractLogo.isError;
            if (!getError)
            {
                lWin.intoBtns();
                lWin.Visibility = Visibility.Visible;
                Visibility = Visibility.Hidden;
            }
            else
            {
                backBtn.Visibility = Visibility.Hidden;

                radioBtn0.Visibility = Visibility.Visible;
                radioBtn1.Visibility = Visibility.Visible;
                radioBtn2.Visibility = Visibility.Visible;

                isDirectoryLabel.Visibility = Visibility.Hidden;
                yesBtn.Visibility = Visibility.Hidden;
                noBtn.Visibility = Visibility.Hidden;

                pasteDirect.Text = string.Empty;
                pasteDirect.Visibility = Visibility.Hidden;
                submitBtn.Visibility = Visibility.Hidden;
            }
            
        }

        private void noBtn_Click(object sender, RoutedEventArgs e)
        {
            pasteDirect.Visibility = Visibility.Visible;
            submitBtn.Visibility = Visibility.Visible;
            pasteDirect.Focus();
            pasteDirect.SelectAll();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if(lWin.Visibility != Visibility.Collapsed)
            {
                Environment.Exit(0);
            }
        }
    }
      
}
