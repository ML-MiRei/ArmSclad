namespace ArmSclad.UI.Main.Modules.ClientsViews
{
    partial class SelectClientForm
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
            CloseButton = new Button();
            NextPageButton = new Button();
            UpdatePageButton = new Button();
            PrevPageButton = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            ClientsList = new ListView();
            panel2 = new Panel();
            ContinueButton = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(NextPageButton);
            panel1.Controls.Add(UpdatePageButton);
            panel1.Controls.Add(PrevPageButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 47);
            panel1.TabIndex = 4;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(884, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(65, 47);
            CloseButton.TabIndex = 7;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // NextPageButton
            // 
            NextPageButton.BackColor = Color.FromArgb(0, 0, 64);
            NextPageButton.FlatAppearance.BorderSize = 0;
            NextPageButton.FlatStyle = FlatStyle.Flat;
            NextPageButton.Image = Properties.Resources.icons8_направо_24;
            NextPageButton.Location = new Point(106, 9);
            NextPageButton.Name = "NextPageButton";
            NextPageButton.Size = new Size(41, 29);
            NextPageButton.TabIndex = 6;
            NextPageButton.UseVisualStyleBackColor = false;
            NextPageButton.Click += NextPageButton_Click;
            // 
            // UpdatePageButton
            // 
            UpdatePageButton.BackColor = Color.FromArgb(0, 0, 64);
            UpdatePageButton.FlatAppearance.BorderSize = 0;
            UpdatePageButton.FlatStyle = FlatStyle.Flat;
            UpdatePageButton.Image = Properties.Resources.icons8_обновить_30;
            UpdatePageButton.Location = new Point(59, 9);
            UpdatePageButton.Name = "UpdatePageButton";
            UpdatePageButton.Size = new Size(41, 29);
            UpdatePageButton.TabIndex = 5;
            UpdatePageButton.UseVisualStyleBackColor = false;
            UpdatePageButton.Click += UpdatePageButton_Click;
            // 
            // PrevPageButton
            // 
            PrevPageButton.BackColor = Color.FromArgb(0, 0, 64);
            PrevPageButton.FlatAppearance.BorderSize = 0;
            PrevPageButton.FlatStyle = FlatStyle.Flat;
            PrevPageButton.Image = Properties.Resources.icons8_налево_24;
            PrevPageButton.Location = new Point(12, 9);
            PrevPageButton.Name = "PrevPageButton";
            PrevPageButton.Size = new Size(41, 29);
            PrevPageButton.TabIndex = 4;
            PrevPageButton.UseVisualStyleBackColor = false;
            PrevPageButton.Click += PrevPageButton_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Имя";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Номер телефона";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Эл. почта";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Адрес";
            columnHeader5.Width = 350;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Статус";
            columnHeader6.Width = 100;
            // 
            // ClientsList
            // 
            ClientsList.BackColor = Color.White;
            ClientsList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            ClientsList.Dock = DockStyle.Fill;
            ClientsList.FullRowSelect = true;
            ClientsList.GridLines = true;
            ClientsList.Location = new Point(10, 57);
            ClientsList.Name = "ClientsList";
            ClientsList.Scrollable = false;
            ClientsList.Size = new Size(949, 436);
            ClientsList.TabIndex = 7;
            ClientsList.UseCompatibleStateImageBehavior = false;
            ClientsList.View = View.Details;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ContinueButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(10, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 55);
            panel2.TabIndex = 8;
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = Color.Green;
            ContinueButton.FlatAppearance.BorderSize = 0;
            ContinueButton.FlatStyle = FlatStyle.Flat;
            ContinueButton.ForeColor = Color.White;
            ContinueButton.Location = new Point(12, 16);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(169, 27);
            ContinueButton.TabIndex = 0;
            ContinueButton.Text = "продолжить";
            ContinueButton.UseVisualStyleBackColor = false;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(949, 10);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 493);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 0, 64);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(959, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 503);
            panel5.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 0, 64);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 493);
            panel6.Name = "panel6";
            panel6.Size = new Size(959, 10);
            panel6.TabIndex = 12;
            // 
            // SelectClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(969, 503);
            Controls.Add(panel2);
            Controls.Add(ClientsList);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выбор клиента";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button NextPageButton;
        private Button UpdatePageButton;
        private Button PrevPageButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView ClientsList;
        private Panel panel2;
        private Button ContinueButton;
        private Button CloseButton;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}