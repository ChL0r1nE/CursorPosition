using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursorPosition
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        private static extern bool GetAsyncKeyState(int vKey);

        private Point _anchor = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();

            UpdatePositionAndColor();
            SetAnchorCheck();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            TopMost = true;
        }

        private Color GetDesktopColor(int x, int y)
        {
            using (Bitmap bitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0,
                        Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                }

                return bitmap.GetPixel(x, y);
            }
        }

        private void HideBackground(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            TransparencyKey = BackColor;
            hideBackgroundButton.Dispose();
        }

        async void UpdatePositionAndColor()
        {
            while (true)
            {
                GetCursorPos(out Point cursorPosition);

                textBoxX.Text = $"{cursorPosition.X - _anchor.X}";
                textBoxY.Text = $"{cursorPosition.Y - _anchor.Y}";

                Color pixelColor = GetDesktopColor(cursorPosition.X, cursorPosition.Y);

                colorBoxR.Text = $"{pixelColor.R}";
                colorBoxG.Text = $"{pixelColor.G}";
                colorBoxB.Text = $"{pixelColor.B}";

                await Task.Delay(100);
            }
        }

        async void SetAnchorCheck()
        {
            while (true)
            {
                await Task.Delay(50);

                if (!GetAsyncKeyState((int)Keys.Space)) continue;

                GetCursorPos(out Point cursorPosition);

                _anchor = new Point(cursorPosition.X, cursorPosition.Y);
                anchorBox.Text = $"anchor {cursorPosition.X} {cursorPosition.Y}";
            }
        }
    }
}
