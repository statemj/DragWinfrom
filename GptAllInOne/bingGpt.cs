using System.Runtime.InteropServices;

namespace GptAllInOne
{
    public partial class bingGpt : Form
    {
        public bingGpt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
        }
        private void clickMinimized(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void clickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // 拖拽窗体移动
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        // 鼠标经过控件 变色

    }
}