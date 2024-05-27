namespace ArmSclad.UI.Modules.Login.View
{
    partial class SigninForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginButton = new Button();
            PasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(0, 0, 64);
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(79, 315);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(311, 39);
            LoginButton.TabIndex = 17;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.White;
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Segoe UI", 14F);
            PasswordTextBox.ForeColor = Color.Navy;
            PasswordTextBox.Location = new Point(77, 218);
            PasswordTextBox.Margin = new Padding(0);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Пароль...";
            PasswordTextBox.Size = new Size(311, 32);
            PasswordTextBox.TabIndex = 15;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.White;
            EmailTextBox.BorderStyle = BorderStyle.None;
            EmailTextBox.Font = new Font("Segoe UI", 14F);
            EmailTextBox.ForeColor = Color.MidnightBlue;
            EmailTextBox.Location = new Point(79, 134);
            EmailTextBox.Margin = new Padding(0);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "Email...";
            EmailTextBox.Size = new Size(311, 32);
            EmailTextBox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(77, 156);
            label3.Name = "label3";
            label3.Size = new Size(309, 20);
            label3.TabIndex = 14;
            label3.Text = "__________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(77, 242);
            label4.Name = "label4";
            label4.Size = new Size(309, 20);
            label4.TabIndex = 16;
            label4.Text = "__________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(79, 114);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 18;
            label1.Text = "Эл. почта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(77, 198);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 19;
            label2.Text = "Пароль";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SigninForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(463, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(label3);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SigninForm";
            Text = "SigninForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox PasswordTextBox;
        private TextBox EmailTextBox;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}