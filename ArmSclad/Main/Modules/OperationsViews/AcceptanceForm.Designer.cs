namespace ArmSclad.UI.Main.Modules.StoragesViews.OperationsViews
{
    partial class AcceptanceForm
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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            CloseButton = new Button();
            panel6 = new Panel();
            ProductsList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            CancelButton = new Button();
            CompleteButton = new Button();
            SelectProducts = new Button();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(555, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 586);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 586);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(10, 576);
            panel3.Name = "panel3";
            panel3.Size = new Size(545, 10);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(545, 10);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(CloseButton);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(545, 43);
            panel5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 11);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 1;
            label1.Text = "Оформление поставки";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(478, 1);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(66, 42);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(ProductsList);
            panel6.Controls.Add(CancelButton);
            panel6.Controls.Add(CompleteButton);
            panel6.Controls.Add(SelectProducts);
            panel6.Controls.Add(groupBox1);
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(10, 53);
            panel6.Name = "panel6";
            panel6.Size = new Size(545, 523);
            panel6.TabIndex = 5;
            // 
            // ProductsList
            // 
            ProductsList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            ProductsList.FullRowSelect = true;
            ProductsList.GridLines = true;
            ProductsList.Location = new Point(28, 78);
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(473, 245);
            ProductsList.TabIndex = 6;
            ProductsList.UseCompatibleStateImageBehavior = false;
            ProductsList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Название";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Кол-во";
            columnHeader3.Width = 200;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(192, 0, 0);
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(288, 441);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(213, 29);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "отмена";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // CompleteButton
            // 
            CompleteButton.BackColor = Color.Green;
            CompleteButton.FlatAppearance.BorderSize = 0;
            CompleteButton.FlatStyle = FlatStyle.Flat;
            CompleteButton.ForeColor = Color.White;
            CompleteButton.Location = new Point(28, 441);
            CompleteButton.Name = "CompleteButton";
            CompleteButton.Size = new Size(213, 29);
            CompleteButton.TabIndex = 4;
            CompleteButton.Text = "сохранить";
            CompleteButton.UseVisualStyleBackColor = false;
            CompleteButton.Click += CompleteButton_Click;
            // 
            // SelectProducts
            // 
            SelectProducts.BackColor = Color.FromArgb(0, 0, 64);
            SelectProducts.FlatAppearance.BorderSize = 0;
            SelectProducts.FlatStyle = FlatStyle.Flat;
            SelectProducts.ForeColor = Color.White;
            SelectProducts.Location = new Point(265, 30);
            SelectProducts.Name = "SelectProducts";
            SelectProducts.Size = new Size(148, 29);
            SelectProducts.TabIndex = 3;
            SelectProducts.Text = "выбор продуктов";
            SelectProducts.UseVisualStyleBackColor = false;
            SelectProducts.Click += SelectProducts_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(28, 329);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 79);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Дополнительные действия";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(224, 36);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(130, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Переупаковка";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 36);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Контроль качества";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 34);
            label2.Name = "label2";
            label2.Size = new Size(183, 20);
            label2.TabIndex = 0;
            label2.Text = "Доставленные продукты:";
            // 
            // AcceptanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(565, 586);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AcceptanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AcceptanceForm";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Button CloseButton;
        private Panel panel6;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label2;
        private Button SelectProducts;
        private Button CancelButton;
        private Button CompleteButton;
        private ListView ProductsList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}