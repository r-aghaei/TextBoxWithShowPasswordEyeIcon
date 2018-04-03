using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Permissions;
using System.ComponentModel;

namespace TextBoxWithPasswordEye
{

    public class ExTextBox : TextBox
    {
        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        const int EM_SETMARGINS = 0xd3;
        const int EC_RIGHTMARGIN = 2;

        Image originalImage = Properties.Resources.Eye;
        Image downImage = Properties.Resources.EyeBlue;
        int eyeButtonWidth = 24;
        char originalPasswordCharacter = '\0';
        bool originalUseSystemPasswordCharacter = false;
        bool showingPassword = false;
        PictureBox eyeButton;
        public ExTextBox() : base()
        {
            eyeButton = CreateEyeButton();
            Controls.Add(eyeButton);
        }
        PictureBox CreateEyeButton()
        {
            var control = new PictureBox();
            control.Image = originalImage;
            control.SizeMode = PictureBoxSizeMode.Zoom;
            control.BackColor = Color.Transparent;
            control.Width = eyeButtonWidth;
            control.Dock = DockStyle.Right;
            control.BorderStyle = BorderStyle.None;
            control.Cursor = Cursors.Arrow;
            control.MouseDown += EyeButton_MouseDown;
            control.MouseUp += EyeButton_MouseUp;
            control.MouseMove += EyeButton_MouseMove;
            control.MouseLeave += EyeButton_MouseLeave;
            control.Visible = false;
            return control;
        }
        private void ShowPassword()
        {
            showingPassword = true;
            originalUseSystemPasswordCharacter = this.UseSystemPasswordChar;
            this.PasswordChar = '\0';
            this.UseSystemPasswordChar = false;
            eyeButton.Image = downImage;
            this.PasswordChar = originalPasswordCharacter;
        }
        private void HidePassword()
        {
            showingPassword = false;
            this.PasswordChar = originalPasswordCharacter;
            this.UseSystemPasswordChar = originalUseSystemPasswordCharacter;
            eyeButton.Image = originalImage;
        }

        bool showPasswordEye;
        [DefaultValue(false)]
        public bool ShowPasswordEye
        {
            get
            {
                return showPasswordEye;
            }
            set
            {
                showPasswordEye = value;
                eyeButton.Visible = value;
                if (value)
                    SetMargin(eyeButtonWidth);
                else
                    SetMargin(0);
            }
        }

        private void EyeButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                eyeButton.Capture = true;
                ShowPassword();
            }
        }
        private void EyeButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (showingPassword)
                HidePassword();
        }
        private void EyeButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (showingPassword && !eyeButton.ClientRectangle.Contains(e.Location))
                HidePassword();
        }
        private void EyeButton_MouseLeave(object sender, EventArgs e)
        {
            if (showingPassword)
                HidePassword();
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (ShowPasswordEye)
                SetMargin(eyeButtonWidth);
        }
        private void SetMargin(int w)
        {
            SendMessage(Handle, EM_SETMARGINS, EC_RIGHTMARGIN, w << 16);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.eyeButton.Image = null;
                originalImage.Dispose();
                downImage.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
