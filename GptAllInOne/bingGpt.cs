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
        // mini winForm Fn
        private void clickMinimized(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        // close winForm Fn
        private void clickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // drag winForm move Fn
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        // call the win32 dll 
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        //  private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        // 控制拖动窗体
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        #region 拖拽窗体变焦改变大小
        // Drag and drop the winform to change the size
        private void bingGpt_MouseMove(object sender, MouseEventArgs e)
        {
            int distance = Math.Abs(e.Y);
            heightBox.Text = distance.ToString();
            // fixed button

            // Change the position of the winform 
            if (e.Button == MouseButtons.Left)
            {//左键按下移动，拖拽调整大小
                if (distance < this.Height * 0.1)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    // SendMessage(Handle, WM_SYSCOMMAND, (IntPtr)SC_SIZE + 8, (IntPtr)(e.X + (e.Y << 16)));
                }

                // MousePosition的参考点是屏幕的左上角，表示鼠标当前相对于屏幕左上角的坐标。this.Left和this.Top的参考点也是屏幕
                if (Cursor == Cursors.SizeNWSE) // 倾斜拖拽 
                {
                    // 改变窗体宽和高的代码，其宽高为鼠标屏幕位置减去窗体的Left，Top距离
                    this.Width = MousePosition.X - this.Left;
                    this.Height = MousePosition.Y - this.Top;
                }
                else if (Cursor == Cursors.SizeWE) // 水平拖拽
                {
                    Width = MousePosition.X - this.Left;
                }
                else if (Cursor == Cursors.SizeNS) // 垂直拖拽
                {
                    Height = MousePosition.Y - this.Top;
                }
                if (this.Height < 50 || this.Width < 190)
                {
                    this.Height = 400;
                    this.Width = 800;
                    //                    MessageBox.Show(distance.ToString());
                }
            }

            //鼠标移动过程中，坐标时刻在改变 
            //当鼠标移动时横坐标距离窗体右边缘5像素以内且纵坐标距离下边缘也在5像素以内时，要将光标变为倾斜的箭头形状
            if (e.Location.X >= this.Width - 5 && e.Location.Y > this.Height - 5)
            {
                this.Cursor = Cursors.SizeNWSE; // 右下角 双向对角线光标
            }
            //当鼠标移动时横坐标距离窗体右边缘5像素以内时，要将光标变为双向水平箭头形状
            else if (e.Location.X >= this.Width - 5)
            {
                this.Cursor = Cursors.SizeWE; // 双向水平光标
            }
            //当鼠标移动时纵坐标距离窗体下边缘5像素以内时，要将光标变为垂直水平箭头形状
            else if (e.Location.Y >= this.Height - 5)
            {
                this.Cursor = Cursors.SizeNS; // 双向垂直光标

            }
            //否则，以外的窗体区域，鼠标星座均为单向箭头（默认）             
            else this.Cursor = Cursors.Arrow;

        }
        #endregion 
        private void bingGpt_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;// 移出窗体变为正常
        }
    }
}