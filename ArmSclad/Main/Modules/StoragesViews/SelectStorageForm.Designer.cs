﻿namespace ArmSclad.UI.Main.Modules.StoragesViews
{
    partial class SelectStorageForm
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
            panel3 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1 = new Panel();
            CloseButton = new Button();
            NextPageButton = new Button();
            UpdatePageButton = new Button();
            PrevPageButton = new Button();
            panel2 = new Panel();
            ContinueButton = new Button();
            StoragesList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(969, 10);
            panel3.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 0, 64);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 493);
            panel6.Name = "panel6";
            panel6.Size = new Size(969, 10);
            panel6.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 483);
            panel4.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 0, 64);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(959, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 483);
            panel5.TabIndex = 15;
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
            panel1.TabIndex = 16;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ContinueButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(10, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 55);
            panel2.TabIndex = 17;
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
            // StoragesList
            // 
            StoragesList.BackColor = Color.White;
            StoragesList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader7, columnHeader3, columnHeader4, columnHeader5 });
            StoragesList.Dock = DockStyle.Fill;
            StoragesList.FullRowSelect = true;
            StoragesList.GridLines = true;
            StoragesList.Location = new Point(10, 57);
            StoragesList.Name = "StoragesList";
            StoragesList.Scrollable = false;
            StoragesList.Size = new Size(949, 381);
            StoragesList.TabIndex = 18;
            StoragesList.UseCompatibleStateImageBehavior = false;
            StoragesList.View = View.Details;
            StoragesList.SelectedIndexChanged += StoragesList_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Название";
            columnHeader2.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Адрес";
            columnHeader7.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Свободное место";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Время открытия";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Время закрытия";
            columnHeader5.Width = 120;
            // 
            // SelectStorageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(969, 503);
            Controls.Add(StoragesList);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectStorageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectStorageForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel6;
        private Panel panel4;
        private Panel panel5;
        private Panel panel1;
        private Button CloseButton;
        private Button NextPageButton;
        private Button UpdatePageButton;
        private Button PrevPageButton;
        private Panel panel2;
        private Button ContinueButton;
        private ListView StoragesList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}