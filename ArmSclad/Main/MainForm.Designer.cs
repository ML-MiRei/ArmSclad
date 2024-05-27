namespace ArmSclad.UI.Main
{
    partial class MainForm
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
            panel1 = new Panel();
            Logout = new Button();
            UserName = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            ToClientsPageButton = new Button();
            ToProductsPageButton = new Button();
            ToStoragePageButton = new Button();
            panel2 = new Panel();
            button6 = new Button();
            PageContent = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            PageContent.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(UserName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(ToClientsPageButton);
            panel1.Controls.Add(ToProductsPageButton);
            panel1.Controls.Add(ToStoragePageButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 802);
            panel1.TabIndex = 0;
            // 
            // Logout
            // 
            Logout.BackColor = Color.FromArgb(192, 0, 0);
            Logout.FlatAppearance.BorderSize = 0;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.ForeColor = Color.White;
            Logout.Location = new Point(12, 731);
            Logout.Name = "Logout";
            Logout.Size = new Size(134, 59);
            Logout.TabIndex = 6;
            Logout.Text = "выйти из\r\nаккаунта";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // UserName
            // 
            UserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserName.AutoSize = true;
            UserName.ForeColor = Color.White;
            UserName.Location = new Point(19, 92);
            UserName.Margin = new Padding(10, 0, 10, 0);
            UserName.Name = "UserName";
            UserName.Size = new Size(50, 20);
            UserName.TabIndex = 5;
            UserName.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_пользователь_50;
            pictureBox1.Location = new Point(19, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 55);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 332);
            button4.Name = "button4";
            button4.Size = new Size(162, 59);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // ToClientsPageButton
            // 
            ToClientsPageButton.Anchor = AnchorStyles.None;
            ToClientsPageButton.Cursor = Cursors.Hand;
            ToClientsPageButton.FlatAppearance.BorderSize = 0;
            ToClientsPageButton.FlatStyle = FlatStyle.Flat;
            ToClientsPageButton.ForeColor = Color.White;
            ToClientsPageButton.Location = new Point(0, 267);
            ToClientsPageButton.Name = "ToClientsPageButton";
            ToClientsPageButton.Size = new Size(162, 59);
            ToClientsPageButton.TabIndex = 2;
            ToClientsPageButton.Text = "клиенты";
            ToClientsPageButton.UseVisualStyleBackColor = true;
            // 
            // ToProductsPageButton
            // 
            ToProductsPageButton.Anchor = AnchorStyles.None;
            ToProductsPageButton.Cursor = Cursors.Hand;
            ToProductsPageButton.FlatAppearance.BorderSize = 0;
            ToProductsPageButton.FlatStyle = FlatStyle.Flat;
            ToProductsPageButton.ForeColor = Color.White;
            ToProductsPageButton.Location = new Point(0, 202);
            ToProductsPageButton.Name = "ToProductsPageButton";
            ToProductsPageButton.Size = new Size(162, 59);
            ToProductsPageButton.TabIndex = 1;
            ToProductsPageButton.Text = "продукты";
            ToProductsPageButton.UseVisualStyleBackColor = true;
            // 
            // ToStoragePageButton
            // 
            ToStoragePageButton.Anchor = AnchorStyles.None;
            ToStoragePageButton.Cursor = Cursors.Hand;
            ToStoragePageButton.FlatAppearance.BorderSize = 0;
            ToStoragePageButton.FlatStyle = FlatStyle.Flat;
            ToStoragePageButton.ForeColor = Color.White;
            ToStoragePageButton.Location = new Point(0, 137);
            ToStoragePageButton.Name = "ToStoragePageButton";
            ToStoragePageButton.Size = new Size(162, 59);
            ToStoragePageButton.TabIndex = 0;
            ToStoragePageButton.Text = "склады";
            ToStoragePageButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(165, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1139, 47);
            panel2.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 128, 128);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(1073, 0);
            button6.Name = "button6";
            button6.Size = new Size(66, 47);
            button6.TabIndex = 0;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // PageContent
            // 
            PageContent.Controls.Add(panel3);
            PageContent.Dock = DockStyle.Fill;
            PageContent.Location = new Point(165, 47);
            PageContent.Name = "PageContent";
            PageContent.Size = new Size(1139, 755);
            PageContent.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 709);
            panel3.Name = "panel3";
            panel3.Size = new Size(1139, 46);
            panel3.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1304, 802);
            Controls.Add(PageContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            PageContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button ToClientsPageButton;
        private Button ToProductsPageButton;
        private Button ToStoragePageButton;
        private Panel panel2;
        private Button button6;
        private Panel PageContent;
        private Panel panel3;
        private Label UserName;
        private PictureBox pictureBox1;
        private Button Logout;
    }
}