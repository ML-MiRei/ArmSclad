namespace ArmSclad.UI.Main.Modules.ProductsViews
{
    partial class SelectProductForm
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
            panel4 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            NextPageButton = new Button();
            UpdatePageButton = new Button();
            PrevPageButton = new Button();
            CloseButton = new Button();
            panel6 = new Panel();
            Continue = new Button();
            ProductsList = new ListView();
            id = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(472, 10);
            panel4.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 538);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 10);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 528);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(462, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 528);
            panel2.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(NextPageButton);
            panel5.Controls.Add(UpdatePageButton);
            panel5.Controls.Add(PrevPageButton);
            panel5.Controls.Add(CloseButton);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(452, 47);
            panel5.TabIndex = 10;
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
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(378, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(74, 47);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(Continue);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(10, 476);
            panel6.Name = "panel6";
            panel6.Size = new Size(452, 62);
            panel6.TabIndex = 11;
            // 
            // Continue
            // 
            Continue.BackColor = Color.Green;
            Continue.FlatAppearance.BorderSize = 0;
            Continue.FlatStyle = FlatStyle.Flat;
            Continue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Continue.ForeColor = Color.White;
            Continue.Location = new Point(12, 13);
            Continue.Name = "Continue";
            Continue.Size = new Size(201, 37);
            Continue.TabIndex = 1;
            Continue.Text = "продолжить";
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // ProductsList
            // 
            ProductsList.BackColor = Color.White;
            ProductsList.Columns.AddRange(new ColumnHeader[] { id, columnHeader2, columnHeader7 });
            ProductsList.Dock = DockStyle.Fill;
            ProductsList.FullRowSelect = true;
            ProductsList.GridLines = true;
            ProductsList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ProductsList.Location = new Point(10, 57);
            ProductsList.MultiSelect = false;
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(452, 419);
            ProductsList.TabIndex = 12;
            ProductsList.UseCompatibleStateImageBehavior = false;
            ProductsList.View = View.Details;
            ProductsList.SelectedIndexChanged += ProductsList_SelectedIndexChanged;
            // 
            // id
            // 
            id.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Название";
            columnHeader2.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Описание";
            columnHeader7.Width = 100;
            // 
            // SelectProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(472, 548);
            Controls.Add(ProductsList);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectProductForm";
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Button NextPageButton;
        private Button UpdatePageButton;
        private Button PrevPageButton;
        private Button CloseButton;
        private Panel panel6;
        private Button Continue;
        private ListView ProductsList;
        private ColumnHeader id;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader7;
    }
}