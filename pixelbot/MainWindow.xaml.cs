using System;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;


namespace pixelbot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonSearchPixelClick(object sender, RoutedEventArgs e)
        {
            string inputHexColorCode = TextBoxHexColor.Text;
            MessageBox.Show(inputHexColorCode);
        }

        private bool SearchPixel(string hexCode)
        {
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height); // current screen 
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
                    }
                }
            }



            return false;
        }
    }
}
