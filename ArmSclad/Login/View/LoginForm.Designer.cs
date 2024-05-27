using ArmSclad.UI.Modules.Login.View;

namespace ArmSclad
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleForm = new Label();
            button1 = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            ToSigninButton = new LinkLabel();
            ToRegistrationButton = new LinkLabel();
            PageContainer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TitleForm
            // 
            TitleForm.Anchor = AnchorStyles.None;
            TitleForm.AutoSize = true;
            TitleForm.Font = new Font("Segoe UI", 20F);
            TitleForm.ForeColor = Color.White;
            TitleForm.Location = new Point(22, 111);
            TitleForm.Name = "TitleForm";
            TitleForm.Size = new Size(94, 46);
            TitleForm.TabIndex = 0;
            TitleForm.Text = "Вход";
            TitleForm.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(40, 34);
            button1.TabIndex = 4;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += CloseForm;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 394);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(161, 380);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(ToSigninButton);
            panel1.Controls.Add(ToRegistrationButton);
            panel1.Controls.Add(TitleForm);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 523);
            panel1.TabIndex = 7;
            // 
            // ToSigninButton
            // 
            ToSigninButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ToSigninButton.AutoSize = true;
            ToSigninButton.LinkColor = Color.FromArgb(192, 192, 255);
            ToSigninButton.Location = new Point(22, 471);
            ToSigninButton.Name = "ToSigninButton";
            ToSigninButton.Size = new Size(41, 20);
            ToSigninButton.TabIndex = 6;
            ToSigninButton.TabStop = true;
            ToSigninButton.Text = "вход";
            ToSigninButton.Visible = false;
            // 
            // ToRegistrationButton
            // 
            ToRegistrationButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ToRegistrationButton.AutoSize = true;
            ToRegistrationButton.LinkColor = Color.FromArgb(192, 192, 255);
            ToRegistrationButton.Location = new Point(22, 471);
            ToRegistrationButton.Name = "ToRegistrationButton";
            ToRegistrationButton.Size = new Size(97, 20);
            ToRegistrationButton.TabIndex = 5;
            ToRegistrationButton.TabStop = true;
            ToRegistrationButton.Text = "регистрация";
            // 
            // PageContainer
            // 
            PageContainer.Dock = DockStyle.Fill;
            PageContainer.Location = new Point(237, 0);
            PageContainer.Name = "PageContainer";
            PageContainer.Size = new Size(445, 523);
            PageContainer.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(682, 523);
            Controls.Add(PageContainer);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private SplitContainer splitContainer1;
        private Label TitleForm;
        private Button button1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Panel PageContainer;
        private LinkLabel ToRegistrationButton;
        private LinkLabel ToSigninButton;
    }
}
