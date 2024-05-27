namespace ArmSclad.UI.Main.Modules.ClientsViews
{
    partial class InfoClientForm
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
            label7 = new Label();
            CloseButton = new Button();
            panel2 = new Panel();
            CompleteButton = new Button();
            CancelButton = new Button();
            AddressTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PhoneNumberTextBox = new TextBox();
            LasstNameTextBox = new TextBox();
            SecondNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 51);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 15);
            label7.Name = "label7";
            label7.Size = new Size(174, 20);
            label7.TabIndex = 1;
            label7.Text = "Информация о клиенте";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(516, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(62, 51);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(CompleteButton);
            panel2.Controls.Add(CancelButton);
            panel2.Controls.Add(AddressTextBox);
            panel2.Controls.Add(EmailTextBox);
            panel2.Controls.Add(PhoneNumberTextBox);
            panel2.Controls.Add(LasstNameTextBox);
            panel2.Controls.Add(SecondNameTextBox);
            panel2.Controls.Add(FirstNameTextBox);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 442);
            panel2.TabIndex = 1;
            // 
            // CompleteButton
            // 
            CompleteButton.BackColor = Color.Green;
            CompleteButton.FlatAppearance.BorderSize = 0;
            CompleteButton.FlatStyle = FlatStyle.Flat;
            CompleteButton.ForeColor = Color.White;
            CompleteButton.Location = new Point(14, 382);
            CompleteButton.Name = "CompleteButton";
            CompleteButton.Size = new Size(257, 29);
            CompleteButton.TabIndex = 14;
            CompleteButton.Text = "сохранить";
            CompleteButton.UseVisualStyleBackColor = false;
            CompleteButton.Click += CompleteButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(192, 0, 0);
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(299, 382);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(257, 29);
            CancelButton.TabIndex = 13;
            CancelButton.Text = "отмена";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(102, 243);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(454, 27);
            AddressTextBox.TabIndex = 12;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(141, 197);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(415, 27);
            EmailTextBox.TabIndex = 11;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(141, 152);
            PhoneNumberTextBox.MaxLength = 11;
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(415, 27);
            PhoneNumberTextBox.TabIndex = 10;
            // 
            // LasstNameTextBox
            // 
            LasstNameTextBox.Location = new Point(141, 109);
            LasstNameTextBox.Name = "LasstNameTextBox";
            LasstNameTextBox.Size = new Size(415, 27);
            LasstNameTextBox.TabIndex = 9;
            // 
            // SecondNameTextBox
            // 
            SecondNameTextBox.Location = new Point(141, 70);
            SecondNameTextBox.Name = "SecondNameTextBox";
            SecondNameTextBox.Size = new Size(415, 27);
            SecondNameTextBox.TabIndex = 8;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(88, 34);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(468, 27);
            FirstNameTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(14, 290);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 59);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Статус";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(221, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(89, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "юр.лицо";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(88, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(98, 24);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "физ. лицо";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(14, 239);
            label6.Name = "label6";
            label6.Size = new Size(71, 28);
            label6.TabIndex = 5;
            label6.Text = "Адрес:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(14, 193);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 4;
            label5.Text = "Эл. почта:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(14, 148);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 3;
            label4.Text = "Телефон:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(14, 105);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 2;
            label3.Text = "Фамилия:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(14, 66);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 1;
            label2.Text = "Отчество:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(14, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 28);
            label1.TabIndex = 0;
            label1.Text = "Имя:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 432);
            panel3.Name = "panel3";
            panel3.Size = new Size(578, 10);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(578, 10);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 0, 64);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 503);
            panel5.TabIndex = 17;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 0, 64);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(588, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 503);
            panel7.TabIndex = 18;
            // 
            // InfoClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 503);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel7);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoClientForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CloseButton;
        private Panel panel2;
        private TextBox FirstNameTextBox;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox AddressTextBox;
        private TextBox EmailTextBox;
        private TextBox PhoneNumberTextBox;
        private TextBox LasstNameTextBox;
        private TextBox SecondNameTextBox;
        private Label label7;
        private Button CompleteButton;
        private Button CancelButton;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel7;
    }
}