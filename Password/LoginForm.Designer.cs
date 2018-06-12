namespace Password
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.JustAButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.MainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MainContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // JustAButton
            // 
            this.JustAButton.Location = new System.Drawing.Point(15, 66);
            this.JustAButton.Name = "JustAButton";
            this.JustAButton.Size = new System.Drawing.Size(505, 42);
            this.JustAButton.TabIndex = 0;
            this.JustAButton.Text = "Кнопка";
            this.JustAButton.UseVisualStyleBackColor = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(15, 29);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(254, 22);
            this.LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.ContextMenuStrip = this.MainContextMenuStrip;
            this.PasswordTextBox.Location = new System.Drawing.Point(275, 29);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(245, 22);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // MainContextMenuStrip
            // 
            this.MainContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPasswordToolStripMenuItem});
            this.MainContextMenuStrip.Name = "contextMenuStrip1";
            this.MainContextMenuStrip.Size = new System.Drawing.Size(198, 28);
            // 
            // ShowPasswordToolStripMenuItem
            // 
            this.ShowPasswordToolStripMenuItem.Name = "ShowPasswordToolStripMenuItem";
            this.ShowPasswordToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.ShowPasswordToolStripMenuItem.Text = "Показать пароль";
            this.ShowPasswordToolStripMenuItem.Click += new System.EventHandler(this.ShowPasswordToolStripMenuItem_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(12, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(47, 17);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(272, 9);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 17);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль";
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 120);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.JustAButton);
            this.Name = "LoginForm";
            this.Text = "Нажми на кнопку и получишь результат";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MainContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JustAButton;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ContextMenuStrip MainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ShowPasswordToolStripMenuItem;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Timer MainTimer;
    }
}

