namespace ArmSclad.UI.Main.Modules.ProductsViews
{
    partial class SelectProductsForm
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
            SelectMode = new CheckBox();
            NextPageButton = new Button();
            UpdatePageButton = new Button();
            PrevPageButton = new Button();
            CloseButton = new Button();
            ProductsList = new ListView();
            id = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            panel2 = new Panel();
            Continue = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(SelectMode);
            panel1.Controls.Add(NextPageButton);
            panel1.Controls.Add(UpdatePageButton);
            panel1.Controls.Add(PrevPageButton);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 47);
            panel1.TabIndex = 1;
            // 
            // SelectMode
            // 
            SelectMode.AutoSize = true;
            SelectMode.Location = new Point(170, 13);
            SelectMode.Name = "SelectMode";
            SelectMode.Size = new Size(213, 24);
            SelectMode.TabIndex = 7;
            SelectMode.Text = "режим выбора продуктов";
            SelectMode.UseVisualStyleBackColor = true;
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
            CloseButton.Location = new Point(853, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(74, 47);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // ProductsList
            // 
            ProductsList.BackColor = Color.White;
            ProductsList.Columns.AddRange(new ColumnHeader[] { id, columnHeader2, columnHeader7, columnHeader3, columnHeader9, columnHeader6, columnHeader4, columnHeader1 });
            ProductsList.Dock = DockStyle.Fill;
            ProductsList.FullRowSelect = true;
            ProductsList.GridLines = true;
            ProductsList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ProductsList.Location = new Point(10, 57);
            ProductsList.MultiSelect = false;
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(927, 420);
            ProductsList.TabIndex = 2;
            ProductsList.UseCompatibleStateImageBehavior = false;
            ProductsList.View = View.Details;
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
            // columnHeader3
            // 
            columnHeader3.Text = "Кол-во ед. в упаковке";
            columnHeader3.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.DisplayIndex = 5;
            columnHeader9.Text = "Занимаемое место упаковкой";
            columnHeader9.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 4;
            columnHeader6.Text = "Кол-во уп. на складе";
            columnHeader6.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Стоимость за упаковку";
            columnHeader4.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Выбранное кол-во";
            // 
            // panel2
            // 
            panel2.Controls.Add(Continue);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(10, 477);
            panel2.Name = "panel2";
            panel2.Size = new Size(927, 62);
            panel2.TabIndex = 3;
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 529);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 0, 64);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 539);
            panel5.Name = "panel5";
            panel5.Size = new Size(937, 10);
            panel5.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(937, 10);
            panel4.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 0, 64);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(937, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 549);
            panel6.TabIndex = 6;
            // 
            // SelectProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(947, 549);
            Controls.Add(ProductsList);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectProductsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button NextPageButton;
        private Button UpdatePageButton;
        private Button PrevPageButton;
        private Button CloseButton;
        private ListView ProductsList;
        private ColumnHeader id;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader4;
        private Panel panel2;
        private Button Continue;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private ColumnHeader columnHeader1;
        private CheckBox SelectMode;
    }
}