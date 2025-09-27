using System;
using System.Drawing;
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

            UpdatePosition();
            SetAnchorCheck();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            TopMost = true;
        }

        private void HideBackground(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            TransparencyKey = BackColor;
            hideBackgroundButton.Dispose();
        }

        async void UpdatePosition()
        {
            while (true)
            {
                GetCursorPos(out Point cursorPosition);

                textBoxX.Text = $"{cursorPosition.X - _anchor.X}";
                textBoxY.Text = $"{cursorPosition.Y - _anchor.Y}";

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
