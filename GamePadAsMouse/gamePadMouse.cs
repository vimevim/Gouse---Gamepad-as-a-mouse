using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenJigWare;
using Microsoft.Win32;


namespace GamePadAsMouse
{
    public partial class gamePadMouse : Form
    {
        public gamePadMouse()
        {
            InitializeComponent();

        }
        private void gamePadMouse_Load(object sender, EventArgs e)
        {
            leftStickValue.Text = "x" + (11 - ayarlar.Default.fast).ToString();
            leftStickTrackbar.Value = ayarlar.Default.fast;
            rightStickValue.Text = "x" + (11 - ayarlar.Default.slow).ToString();
            rightStickTrackbar.Value = ayarlar.Default.slow;
            joystickHook.Enabled = true;

            //run at sturtup checked controll
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue("GamePadAsMouse").ToString() == "\"" + Application.ExecutablePath + "\"")
                { // Eğer regeditte varsa, checkbox ı işaretle
                    runAtStartUp.Checked = true;
                }
            }
            catch
            {

            }
        }
        private void joystickHook_Tick(object sender, EventArgs e)
        {
            JoystickCheckAlive();
        }
        private void mouseTimer_Tick(object sender, EventArgs e)
        {
            m_CJoy.Update();
            JoystickCheckMouse();
        }

        private void buttonTimer_Tick(object sender, EventArgs e)
        {
            JoystickCheckButton();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        //pencereyi hareket ettirme fonksiyonları
        int panelGuiderLeft, panelGuiderTop;
        private void panelGuider_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panelGuiderLeft = e.X;
                panelGuiderTop = e.Y;
            }
        }
        private void panelGuider_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = Cursor.Position.X - panelGuiderLeft;
                this.Top = Cursor.Position.Y - panelGuiderTop;
            }
        }

        //sol joystick için hız ayarı yapıyoruz
        private void leftStickTrackbar_Scroll(object sender, EventArgs e)
        {
            ayarlar.Default.fast = leftStickTrackbar.Value;
            leftStickValue.Text = "x" + (11 - leftStickTrackbar.Value).ToString();
        }
        //sağ joystick için hız ayarı yapıyoruz
        private void rightStickTrackbar_Scroll(object sender, EventArgs e)
        {
            ayarlar.Default.slow = rightStickTrackbar.Value;
            rightStickValue.Text = "x" + (11 - rightStickTrackbar.Value).ToString();
        }

        private Ojw.CJoystick m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0);
        private Ojw.CTimer m_CTmr_Joystick = new Ojw.CTimer();

        string labelDegeri = "";


        //joystick bağlantısını kontrol ediyoruz
        private void JoystickCheckAlive()
        {
            Color colorAlive = Color.Green;
            Color colorDeath = Color.Gray;
            if (m_CJoy.IsValid == false)
            {
                if (lbJoystick.ForeColor != colorDeath)
                {
                    lbJoystick.Text = "Joystick (No Connected)";
                    lbJoystick.ForeColor = colorDeath;
                    buttonTimer.Enabled = false;
                    mouseTimer.Enabled = false;
                    stopOrStart.Enabled = false;
                }
                if (m_CTmr_Joystick.Get() > 3000)
                {
                    Ojw.CMessage.Write("Joystick Check again");
                    m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0);

                    if (m_CJoy.IsValid == false)
                    {
                        Ojw.CMessage.Write("But we can't find a joystick device in here. Check your joystick device");
                        m_CTmr_Joystick.Set();
                    }
                    else Ojw.CMessage.Write("Joystick is Connected");
                }
            }
            else
            {
                if (lbJoystick.ForeColor != colorAlive)
                {
                    lbJoystick.Text = "Joystick (Connected)";
                    lbJoystick.ForeColor = colorAlive;
                }
                mouseTimer.Enabled = true;
                buttonTimer.Enabled = true;
                stopOrStart.Enabled = true;
            }
        }
        bool show = true;
        bool mouseMod = true;
        bool mouseLeftClicked = true;
        bool mouseRightClicked = true;
        bool visibility = true;
        bool moder = true;

        //mouse codes
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern void mouse_event(uint flag, uint _x, uint _y, uint btn, uint exInfo);
        private const int MOUSEEVENT_LEFTDOWN = 0x02;//Left click pressed
        private const int MOUSEEVENT_LEFTUP = 0x04;//Left click released
        private const int MOUSEEVENT_RIGHTDOWN = 0x08; //Right click pressed
        private const int MOUSEEVENT_RIGHTUP = 0x10; //Right click released
        //keyboard volume-up-down
        [DllImport("user32.dll")]
        public static extern void SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        private void Moder()
        {
            if (mouseMod == false)
            {
                mouseMod = true;
            }
            else if (mouseMod == true)
            {
                mouseMod = false;
            }
        }
        private void Visibility()
        {
            if (show == true)
            {
                this.Hide();
                show = false;
            }
            else if (show == false)
            {
                this.Show();
                show = true;
            }
        }
        private void JoystickCheckMouse()
        {
            if (mouseMod == true)
            {
                //100 ile çarp virgülü yok et
                int leftThumbX = (int)(m_CJoy.GetPos0 * 100);
                int leftThumbY = (int)(m_CJoy.GetPos1 * 100);
                int rightThumbX = (int)(m_CJoy.GetPos2 * 100);
                int rightThumbY = (int)(m_CJoy.GetPos3 * 100);
                MouseMoveLeft(leftThumbX - 49, leftThumbY - 49);
                MouseMoveRight(rightThumbX - 50, rightThumbY - 50);
            }
        }
        private void JoystickCheckButton()
        {
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button9) == true)
            {
                labelDegeri = "select";
                if (moder == true)
                {
                    moder = false;
                }
            }
            if (m_CJoy.IsUp(Ojw.CJoystick.PadKey.Button9) == true)
            {
                if (moder == false)
                {
                    Moder();
                    moder = true;
                }
            }
            if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button10) == true)
            {
                labelDegeri = "start";
                if (visibility == true)
                {
                    visibility = false;
                }
            }
            if (m_CJoy.IsUp(Ojw.CJoystick.PadKey.Button10) == true)
            {
                if (visibility == false)
                {

                    Visibility();
                    visibility = true;
                }
            }
            if (mouseMod == true)
            {
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVLeft) == true)
                {
                    labelDegeri = "← ";
                    SendKeys.Send("{LEFT}");
                }
                else if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVRight) == true)
                {
                    labelDegeri = "→ ";
                    SendKeys.Send("{RIGHT}");
                }
                else
                {
                    labelDegeri = "";
                }

                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVUp) == true)
                {
                    labelDegeri += "↑";
                    SendKeys.Send("{UP}");
                }
                else if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.POVDown) == true)
                {
                    labelDegeri += "↓";
                    SendKeys.Send("{DOWN}");
                }

                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button4) == true)
                {
                    labelDegeri = "Y";
                    SendKeys.Send("%{LEFT}");//alt-left, undo
                }
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button3) == true)
                {
                    labelDegeri = "X";
                    SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
                    //volume-down

                }
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button2) == true)
                {
                    labelDegeri = "B";
                    SendKeys.Send("%{RIGHT}");//alt-right, redo
                }
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button1) == true)
                {
                    labelDegeri = "A";
                    SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
                    //vol-up
                }

                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button5) == true)
                {
                    labelDegeri = "L1";
                    SendKeys.Send("{TAB}");
                }
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button6) == true)
                {
                    labelDegeri = "R1";
                    SendKeys.Send("{ENTER}");
                }
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button7) == true)
                {
                    labelDegeri = "L2";
                    SendKeys.Send("{ESC}");
                }
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button8) == true)
                {
                    labelDegeri = "R2";
                    SendKeys.Send("{ENTER}");
                }

                //Fare tıklamasını tek seferlik hale getiren kod bloğu
                label1.Text = labelDegeri;
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button11) == true)
                {
                    if (mouseLeftClicked == true)
                    {
                        mouse_event(MOUSEEVENT_LEFTDOWN, 0, 0, 0, 0);
                        mouseLeftClicked = false;
                    }
                }
                if (m_CJoy.IsUp(Ojw.CJoystick.PadKey.Button11) == true)
                {
                    if (mouseLeftClicked == false)
                    {
                        mouse_event(MOUSEEVENT_LEFTUP, 0, 0, 0, 0);
                        mouseLeftClicked = true;
                    }
                }
                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button12) == true)
                {
                    if (mouseRightClicked == true)
                    {
                        mouse_event(MOUSEEVENT_RIGHTDOWN, 0, 0, 0, 0);
                        mouseRightClicked = false;
                    }
                }
                if (m_CJoy.IsUp(Ojw.CJoystick.PadKey.Button12) == true)
                {
                    if (mouseRightClicked == false)
                    {
                        mouse_event(MOUSEEVENT_RIGHTUP, 0, 0, 0, 0);
                        mouseRightClicked = true;
                    }
                }
            }
        }

        //left joystick mouse movement
        public void MouseMoveLeft(int posx, int posy)
        {
            Cursor.Position = new Point(Cursor.Position.X + posx / ayarlar.Default.fast, Cursor.Position.Y + posy / ayarlar.Default.fast);
            //Cursor.Clip = new Rectangle(Screen.PrimaryScreen.WorkingArea.Location, Screen.PrimaryScreen.WorkingArea.Size);
        }
        //right joystick mouse movement
        public void MouseMoveRight(int posx, int posy)
        {
            Cursor.Position = new Point(Cursor.Position.X + posx / ayarlar.Default.slow, Cursor.Position.Y + posy / ayarlar.Default.slow);
            //Cursor.Clip = new Rectangle(Screen.PrimaryScreen.WorkingArea.Location, Screen.PrimaryScreen.WorkingArea.Size);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visibility();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visibility();
        }

        private void save_Click(object sender, EventArgs e)
        {
            ayarlar.Default.Save();
        }

        //run at startup checkedchanged
        private void runAtStartUp_CheckedChanged(object sender, EventArgs e)
        {
            if (runAtStartUp.Checked)
            { //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("GamePadAsMouse", "\"" + Application.ExecutablePath + "\"");
            }
            else
            {  //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("GamePadAsMouse");
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visibility();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //switcher kodu
        private void stopOrStart_Click(object sender, EventArgs e)
        {
            if (stopOrStart.Text == "STOP")
            {
                stopOrStart.Text = "START";
                joystickHook.Enabled = false;
                buttonTimer.Enabled = false;
                mouseTimer.Enabled = false;
            }
            else if (stopOrStart.Text == "START")
            {
                joystickHook.Enabled = true;
                buttonTimer.Enabled = true;
                mouseTimer.Enabled = true;
                stopOrStart.Text = "STOP";
            }
        }
    }
}
