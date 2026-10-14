using System;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;
using System.Runtime.InteropServices;


namespace pixelbot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const UInt32 MOUSEEVENTF_LEFTUP = 0x0004;
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInf);

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

        }

        private void OnButtonSearchPixelClick(object sender, RoutedEventArgs e)
        {
            string inputHexColorCode = TextBoxHexColor.Text;
            SearchPixel(inputHexColorCode);
        }
        private void DoubleClickAtPosition(int posX, int posY)
        { 
            SetCursorPos(posX, posY);
            Click();
            System.Threading.Thread.Sleep(250);
            Click();
        }

        private bool SearchPixel(string hexCode)
        {
            //Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height); // current screen 
            Bitmap bitmap = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height); // current screen 


            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size); //screen content (as a ss)

            Color desiredPixelColor = ColorTranslator.FromHtml(hexCode);

            for(int x=0; x<SystemInformation.VirtualScreen.Height; x++)
            {
                for(int y=0; y<SystemInformation.VirtualScreen.Height; y++)
                {
                    Color currentPixelColor = bitmap.GetPixel(x, y);

                    if(desiredPixelColor == currentPixelColor)
                    {
                        MessageBox.Show(String.Format("Found Pixel at {0}, {1} - Now set mouse cursor", x , y));

                        DoubleClickAtPosition(x, y);
                        return true;
                    }
                }
            }



            return false;
        }
    }
}
