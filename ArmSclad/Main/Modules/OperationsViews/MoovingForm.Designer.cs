namespace ArmSclad.UI.Main.Modules.OperationsViews
{
    partial class MoovingForm
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
            label2 = new Label();
            CloseButton = new Button();
            ProductsList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            CancelButton = new Button();
            CompleteButton = new Button();
            SelectProduct = new Button();
            SelectStorage = new Button();
            label3 = new Label();
            NameStorage = new Label();
            label1 = new Label();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(597, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 468);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 468);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(587, 10);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(10, 458);
            panel4.Name = "panel4";
            panel4.Size = new Size(587, 10);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(CloseButton);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(587, 52);
            panel5.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 16);
            label2.Name = "label2";
            label2.Size = new Size(280, 20);
            label2.TabIndex = 1;
            label2.Text = "Оформление перемещения продуктов";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(524, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(63, 52);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // ProductsList
            // 
            ProductsList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            ProductsList.GridLines = true;
            ProductsList.Location = new Point(44, 182);
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(506, 176);
            ProductsList.TabIndex = 17;
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
            columnHeader3.Text = "Количество";
            columnHeader3.Width = 120;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(192, 0, 0);
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(320, 383);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(230, 29);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "отмена";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // CompleteButton
            // 
            CompleteButton.BackColor = Color.Green;
            CompleteButton.FlatAppearance.BorderSize = 0;
            CompleteButton.FlatStyle = FlatStyle.Flat;
            CompleteButton.ForeColor = Color.White;
            CompleteButton.Location = new Point(44, 383);
            CompleteButton.Name = "CompleteButton";
            CompleteButton.Size = new Size(230, 29);
            CompleteButton.TabIndex = 15;
            CompleteButton.Text = "сохранить";
            CompleteButton.UseVisualStyleBackColor = false;
            CompleteButton.Click += CompleteButton_Click;
            // 
            // SelectProduct
            // 
            SelectProduct.BackColor = Color.FromArgb(0, 0, 64);
            SelectProduct.FlatAppearance.BorderSize = 0;
            SelectProduct.FlatStyle = FlatStyle.Flat;
            SelectProduct.ForeColor = Color.White;
            SelectProduct.Location = new Point(374, 132);
            SelectProduct.Name = "SelectProduct";
            SelectProduct.Size = new Size(176, 29);
            SelectProduct.TabIndex = 14;
            SelectProduct.Text = "выбор продуктов";
            SelectProduct.UseVisualStyleBackColor = false;
            SelectProduct.Click += SelectProduct_Click;
            // 
            // SelectStorage
            // 
            SelectStorage.BackColor = Color.FromArgb(0, 0, 64);
            SelectStorage.FlatAppearance.BorderSize = 0;
            SelectStorage.FlatStyle = FlatStyle.Flat;
            SelectStorage.ForeColor = Color.White;
            SelectStorage.Location = new Point(374, 89);
            SelectStorage.Name = "SelectStorage";
            SelectStorage.Size = new Size(176, 29);
            SelectStorage.TabIndex = 13;
            SelectStorage.Text = "выбор склада";
            SelectStorage.UseVisualStyleBackColor = false;
            SelectStorage.Click += SelectStorage_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 136);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 12;
            label3.Text = "Выбранные продукты:";
            // 
            // NameStorage
            // 
            NameStorage.AutoSize = true;
            NameStorage.Location = new Point(213, 93);
            NameStorage.Name = "NameStorage";
            NameStorage.Size = new Size(77, 20);
            NameStorage.TabIndex = 11;
            NameStorage.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 93);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 10;
            label1.Text = "Конечный склад:";
            // 
            // MoovingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(607, 468);
            Controls.Add(ProductsList);
            Controls.Add(CancelButton);
            Controls.Add(CompleteButton);
            Controls.Add(SelectProduct);
            Controls.Add(SelectStorage);
            Controls.Add(label3);
            Controls.Add(NameStorage);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MoovingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MoovingForm";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private Button CloseButton;
        private ListView ProductsList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button CancelButton;
        private Button CompleteButton;
        private Button SelectProduct;
        private Button SelectStorage;
        private Label label3;
        private Label NameStorage;
        private Label label1;
    }
}