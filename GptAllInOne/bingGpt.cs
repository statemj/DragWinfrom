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
        // �����϶�����
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        #region ��ק����佹�ı��С
        // Drag and drop the winform to change the size
        private void bingGpt_MouseMove(object sender, MouseEventArgs e)
        {
            int distance = Math.Abs(e.Y);
            heightBox.Text = distance.ToString();
            // fixed button

            // Change the position of the winform 
            if (e.Button == MouseButtons.Left)
            {//��������ƶ�����ק������С
                if (distance < this.Height * 0.1)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    // SendMessage(Handle, WM_SYSCOMMAND, (IntPtr)SC_SIZE + 8, (IntPtr)(e.X + (e.Y << 16)));
                }

                // MousePosition�Ĳο�������Ļ�����Ͻǣ���ʾ��굱ǰ�������Ļ���Ͻǵ����ꡣthis.Left��this.Top�Ĳο���Ҳ����Ļ
                if (Cursor == Cursors.SizeNWSE) // ��б��ק 
                {
                    // �ı䴰���͸ߵĴ��룬����Ϊ�����Ļλ�ü�ȥ�����Left��Top����
                    this.Width = MousePosition.X - this.Left;
                    this.Height = MousePosition.Y - this.Top;
                }
                else if (Cursor == Cursors.SizeWE) // ˮƽ��ק
                {
                    Width = MousePosition.X - this.Left;
                }
                else if (Cursor == Cursors.SizeNS) // ��ֱ��ק
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

            //����ƶ������У�����ʱ���ڸı� 
            //������ƶ�ʱ��������봰���ұ�Ե5��������������������±�ԵҲ��5��������ʱ��Ҫ������Ϊ��б�ļ�ͷ��״
            if (e.Location.X >= this.Width - 5 && e.Location.Y > this.Height - 5)
            {
                this.Cursor = Cursors.SizeNWSE; // ���½� ˫��Խ��߹��
            }
            //������ƶ�ʱ��������봰���ұ�Ե5��������ʱ��Ҫ������Ϊ˫��ˮƽ��ͷ��״
            else if (e.Location.X >= this.Width - 5)
            {
                this.Cursor = Cursors.SizeWE; // ˫��ˮƽ���
            }
            //������ƶ�ʱ��������봰���±�Ե5��������ʱ��Ҫ������Ϊ��ֱˮƽ��ͷ��״
            else if (e.Location.Y >= this.Height - 5)
            {
                this.Cursor = Cursors.SizeNS; // ˫��ֱ���

            }
            //��������Ĵ����������������Ϊ�����ͷ��Ĭ�ϣ�             
            else this.Cursor = Cursors.Arrow;

        }
        #endregion 
        private void bingGpt_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;// �Ƴ������Ϊ����
        }
    }
}