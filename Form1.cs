using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


namespace CursorPosition
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out Point lpPoint);

        public Form1()
        {
            InitializeComponent();

            new Thread(UpdatePosition).Start();
        }

        private void UpdatePosition()
        {
            while (true)
            {
                GetCursorPos(out Point defPnt);

                textBoxX.Text = defPnt.X.ToString();
                textBoxY.Text = defPnt.Y.ToString();

                Thread.Sleep(100);
            }
        }
    }
}
