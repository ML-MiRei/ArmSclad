namespace ArmSclad.UI.Main.Modules.StoragesViews
{
    partial class InfoStorageForm
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
            label6 = new Label();
            CloseButton = new Button();
            panel2 = new Panel();
            CancelButton = new Button();
            SaveButton = new Button();
            label5 = new Label();
            ClosingTimePicker = new DateTimePicker();
            OpeningTimePicker = new DateTimePicker();
            CapacityTextBox = new TextBox();
            AddressTextBox = new TextBox();
            NameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 47);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 13);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 1;
            label6.Text = "Информация о складе";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(605, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(64, 47);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(CancelButton);
            panel2.Controls.Add(SaveButton);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ClosingTimePicker);
            panel2.Controls.Add(OpeningTimePicker);
            panel2.Controls.Add(CapacityTextBox);
            panel2.Controls.Add(AddressTextBox);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(667, 406);
            panel2.TabIndex = 1;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(192, 0, 0);
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(355, 316);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(275, 29);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Green;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(37, 316);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(275, 29);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(346, 170);
            label5.Name = "label5";
            label5.Size = new Size(20, 28);
            label5.TabIndex = 9;
            label5.Text = "-";
            // 
            // ClosingTimePicker
            // 
            ClosingTimePicker.Font = new Font("Segoe UI", 12F);
            ClosingTimePicker.Format = DateTimePickerFormat.Time;
            ClosingTimePicker.Location = new Point(382, 170);
            ClosingTimePicker.Name = "ClosingTimePicker";
            ClosingTimePicker.ShowUpDown = true;
            ClosingTimePicker.Size = new Size(119, 34);
            ClosingTimePicker.TabIndex = 8;
            // 
            // OpeningTimePicker
            // 
            OpeningTimePicker.Font = new Font("Segoe UI", 12F);
            OpeningTimePicker.Format = DateTimePickerFormat.Time;
            OpeningTimePicker.Location = new Point(209, 170);
            OpeningTimePicker.Name = "OpeningTimePicker";
            OpeningTimePicker.ShowUpDown = true;
            OpeningTimePicker.Size = new Size(119, 34);
            OpeningTimePicker.TabIndex = 7;
            // 
            // CapacityTextBox
            // 
            CapacityTextBox.Font = new Font("Segoe UI", 12F);
            CapacityTextBox.Location = new Point(203, 238);
            CapacityTextBox.Name = "CapacityTextBox";
            CapacityTextBox.PlaceholderText = "0";
            CapacityTextBox.Size = new Size(427, 34);
            CapacityTextBox.TabIndex = 6;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Font = new Font("Segoe UI", 12F);
            AddressTextBox.Location = new Point(132, 104);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.PlaceholderText = "адрес..";
            AddressTextBox.Size = new Size(498, 34);
            AddressTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 12F);
            NameTextBox.Location = new Point(166, 38);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "название..";
            NameTextBox.Size = new Size(464, 34);
            NameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(37, 241);
            label4.Name = "label4";
            label4.Size = new Size(133, 28);
            label4.TabIndex = 3;
            label4.Text = "Вместимость:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(37, 175);
            label3.Name = "label3";
            label3.Size = new Size(146, 28);
            label3.TabIndex = 2;
            label3.Text = "Время работы:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(37, 107);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 1;
            label2.Text = "Адрес:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(37, 41);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // InfoStorageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 453);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoStorageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStorageForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CloseButton;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private DateTimePicker ClosingTimePicker;
        private DateTimePicker OpeningTimePicker;
        private TextBox CapacityTextBox;
        private TextBox AddressTextBox;
        private TextBox NameTextBox;
        private Label label5;
        private Button CancelButton;
        private Button SaveButton;
        private Label label6;
    }
}