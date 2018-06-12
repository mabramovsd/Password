using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Password
{
    public partial class LoginForm : Form
    {
        private int ShowPasswordStart = 0;

        Button[] LangButtons = new Button[100];
        int LangButtonCount = 0;

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

            String LangPath = Application.StartupPath + "\\Lang";
            String[] FilesList = Directory.GetFiles(LangPath, "*.txt");
            LangButtonCount = FilesList.Length;

            for (int LangIndex = 0; LangIndex < LangButtonCount; LangIndex++)
            {
                LangButtons[LangIndex] = new Button();
                LangButtons[LangIndex].Top = 5 + 45 * LangIndex;
                LangButtons[LangIndex].Height = 40;
                LangButtons[LangIndex].Left = 400;
                LangButtons[LangIndex].Width = 50;
                LangButtons[LangIndex].Text =
                    Path.GetFileName(FilesList[LangIndex]).Replace(".txt", "");
                LangButtons[LangIndex].MouseClick += new MouseEventHandler(LangButtonClick);
                this.Controls.Add(LangButtons[LangIndex]);
            }
        }

        private void LangButtonClick(object sender, EventArgs e)
        {
            for (int LangIndex = 0; LangIndex < LangButtonCount; LangIndex++)
            {
                if (sender.Equals(LangButtons[LangIndex]))
                {
                    ChangeLang(LangButtons[LangIndex].Text);
                }
            }
        }

        private void ChangeLang(String Lang)
        {
            String FileName = Application.StartupPath + "\\Lang\\" + Lang + ".txt";
            StreamReader stream = new StreamReader(FileName, Encoding.UTF8);
            string CurrentLine = "";

            while (CurrentLine != null)
            {
                #region Reading Params
                LoginLabel.Text = ReadParam(CurrentLine, "LOGIN", LoginLabel.Text);
                PasswordLabel.Text = ReadParam(CurrentLine, "PASSWORD", PasswordLabel.Text);
                JustAButton.Text = ReadParam(CurrentLine, "BUTTON", JustAButton.Text);
                this.Text = ReadParam(CurrentLine, "PUSHTHEBTN", this.Text);
                ShowPasswordToolStripMenuItem.Text = ReadParam(CurrentLine, "SHOWPASSWORD", ShowPasswordToolStripMenuItem.Text);
                #endregion

                CurrentLine = stream.ReadLine();
            }

            stream.Close();
        }


        public String ReadParam(String LineFromFile, String ParamName, String DefaultValue)
        {
            String ParamValue = DefaultValue;
            String paramFullName = ParamName + " = ";
            if (LineFromFile.Length > paramFullName.Length &&
                LineFromFile.Substring(0, paramFullName.Length) == paramFullName)
            {
                ParamValue = LineFromFile.Substring(paramFullName.Length);
            }

            return ParamValue;
        }

        private void ENGButton_Click(object sender, EventArgs e)
        {
        }

        private void RUSButton_Click(object sender, EventArgs e)
        {
        }

        private void JustAButton_Click(object sender, EventArgs e)
        {
        }
    }
}
