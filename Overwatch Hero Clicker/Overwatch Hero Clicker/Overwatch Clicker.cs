using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;
using System.Threading;

namespace Overwatch_Hero_Clicker
{
    public partial class Overwatch_Clicker : Form
    {
        #region user32.dll

        [DllImport("user32.dll")]
        static extern void keybd_event(byte vk, byte scan, int flags, ref int extrainfo);

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        //핫키등록
        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);

        //핫키제거
        [DllImport("user32.dll")]
        private static extern int UnregisterHotKey(int hwnd, int id);

        #endregion

        #region mouse control
        private const uint MOUSEMOVE = 0x0001;   // 마우스 이동
        private const uint ABSOLUTEMOVE = 0x8000;   // 전역 위치
        private const uint LBUTTONDOWN = 0x0002;   // 왼쪽 마우스 버튼 눌림
        private const uint LBUTTONUP = 0x0004;   // 왼쪽 마우스 버튼 떼어짐
        #endregion

        public Overwatch_Clicker()
        {
            InitializeComponent();
        }

        private static int X, Y;


        private void Overwatch_Clicker_Load(object sender, EventArgs e)
        {
            // 0x0 : 조합키 없이 사용, 0x1: ALT, 0x2: Ctrl, 0x3: Shift
            RegisterHotKey((int)this.Handle, 0, 0x2, (int)Keys.Q);
            RegisterHotKey((int)this.Handle, 1, 0x2, (int)Keys.W);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            click.Enabled = true;
        }

        private void ClickMouse(Point pos)
        {
            Cursor.Position = new Point(X, Y);
            mouse_event(LBUTTONDOWN, (uint)pos.X, (uint)pos.Y, 0, 0);
            mouse_event(LBUTTONUP, (uint)pos.X, (uint)pos.Y, 0, 0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LabPoint.Text = $"현재 위치 : ({Cursor.Position.X}, {Cursor.Position.Y})";
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == (int)0x312) //핫키가 눌러지면 312 정수 메세지를 받게됨
            {
                if (m.WParam == (IntPtr)0x0) // 그 키의 ID가 0이면
                {
                    X = Cursor.Position.X;
                    Y = Cursor.Position.Y;
                    LabSavePoint.Text = $"클릭할 위치 : ({X}, {Y})";
                    MessageBox.Show($"클릭할 위치가 저장되었습니다.\n시작 버튼을 눌러 오토마우스를 시작하세요.");
                }
                if (m.WParam == (IntPtr)0x1) // 그 키의 ID가 1이면
                {
                    click.Enabled = false;
                    MessageBox.Show("오토마우스가 정지되었습니다.");
                }
            }
        }

        private void click_Tick(object sender, EventArgs e)
        {
            ClickMouse(new Point(X, Y));
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void Overwatch_Clicker_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnregisterHotKey((int)this.Handle, 0); //이 폼에 ID가 0인 핫키 해제
            UnregisterHotKey((int)this.Handle, 1);
        }
    }
}
