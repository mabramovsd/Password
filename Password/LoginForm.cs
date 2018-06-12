using System;
using System.Text;
using System.Windows.Forms;

namespace Password
{
    public partial class LoginForm : Form
    {
        private int ShowPasswordStart = 0;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPasswordStart = Environment.TickCount;
            PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            int CurrentTime = Environment.TickCount;
            if (CurrentTime - ShowPasswordStart >= 3000)
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}
