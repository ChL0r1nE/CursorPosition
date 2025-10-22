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

        private readonly Bitmap _screenshotedBitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);
        private readonly Action _onUpade;

        private Point _anchor = new Point(0, 0);
        private float _scale = 1f;

        private bool _screenshoted = false;
        private bool _isMinilized = false;
        private bool _saved = false;

        public Form1()
        {
            InitializeComponent();

            _onUpade += UpdateAnchor;
            _onUpade += UpdatePositionAndColor;
            _onUpade += UpdateScreenshot;
            _onUpade += UpdateSave;

            UpdateLoop();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            TopMost = true;
        }

        async private void UpdateLoop()
        {
            while (true)
            {
                if (!_saved)
                    _onUpade?.Invoke();
                else
                    UpdateSave();

                await Task.Delay(100);
            }
        }

        private Color GetDesktopColor(int x, int y)
        {
            if (_screenshoted)
                return _screenshotedBitmap.GetPixel(x, y);
            else
            {
                using (Bitmap bitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                        graphics.CopyFromScreen(0, 0, 0, 0, new Size(1920, 1080), CopyPixelOperation.SourceCopy);

                    return bitmap.GetPixel(x, y);
                }
            }
        }

        private void HideBackground(object sender, EventArgs e)
        {
            _isMinilized = !_isMinilized;
            ScaleComboBox.Visible = !_isMinilized;

            FormBorderStyle = _isMinilized ? FormBorderStyle.None : FormBorderStyle.FixedSingle;
            TransparencyKey = _isMinilized ? BackColor : Color.Violet;
        }

        private void UpdatePositionAndColor()
        {
            GetCursorPos(out Point cursorPosition);

            textBoxX.Text = $"{cursorPosition.X - _anchor.X}";
            textBoxY.Text = $"{cursorPosition.Y - _anchor.Y}";

            Color pixelColor;

            if (_scale != 1f)
            {
                int scaledX = (int)(cursorPosition.X * _scale);
                int scaledY = (int)(cursorPosition.Y * _scale);

                ScaledTextBoxX.Text = $"{scaledX}";
                ScaledTextBoxY.Text = $"{scaledY}";

                pixelColor = GetDesktopColor(scaledX, scaledY);
            }
            else
                pixelColor = GetDesktopColor(cursorPosition.X, cursorPosition.Y);

            colorBoxR.Text = $"{pixelColor.R}";
            colorBoxG.Text = $"{pixelColor.G}";
            colorBoxB.Text = $"{pixelColor.B}";
        }

        private void UpdateAnchor()
        {
            if (GetAsyncKeyState((int)Keys.NumPad8))
            {
                GetCursorPos(out Point cursorPosition);
                _anchor = new Point(cursorPosition.X, cursorPosition.Y);

                anchorTextBox.Text = $"anchor {_anchor.X} {_anchor.Y}";
                anchorTextBox.Visible = !(_anchor.X == 0 && _anchor.Y == 0);
            }
            else if (GetAsyncKeyState((int)Keys.NumPad7))
            {
                _anchor = new Point(0, 0);

                anchorTextBox.Text = $"anchor {_anchor.X} {_anchor.Y}";
                anchorTextBox.Visible = !(_anchor.X == 0 && _anchor.Y == 0);
            }
        }

        private void UpdateScreenshot()
        {
            if (!GetAsyncKeyState((int)Keys.NumPad6)) return;

            _screenshoted = !_screenshoted;
            frozedIndicator.Visible = _screenshoted;

            using (Graphics graphics = Graphics.FromImage(_screenshotedBitmap))
                graphics.CopyFromScreen(0, 0, 0, 0, new Size(1920, 1080), CopyPixelOperation.SourceCopy);
        }

        private void UpdateSave()
        {
            if (!GetAsyncKeyState((int)Keys.NumPad2)) return;

            _saved = !_saved;
            dataSavedIndicator.Visible = _saved;
        }

        private void ScaleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _scale = int.Parse(ScaleComboBox.Text) / 100f;
            ScaledTextBoxX.Visible = _scale != 1f;
            ScaledTextBoxY.Visible = _scale != 1f;
        }
    }
}
