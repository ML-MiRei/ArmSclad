namespace ArmSclad.UI.Main.Modules.OperationsWithProductsViews
{
    partial class OperationsWithProductsForm
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
            SelectProduct = new Button();
            NameProduct = new Label();
            NextPageButton = new Button();
            UpdatePageButton = new Button();
            PrevPageButton = new Button();
            ProductsList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(SelectProduct);
            panel1.Controls.Add(NameProduct);
            panel1.Controls.Add(NextPageButton);
            panel1.Controls.Add(UpdatePageButton);
            panel1.Controls.Add(PrevPageButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 47);
            panel1.TabIndex = 3;
            // 
            // SelectProduct
            // 
            SelectProduct.BackColor = Color.FromArgb(0, 0, 64);
            SelectProduct.FlatAppearance.BorderSize = 0;
            SelectProduct.FlatStyle = FlatStyle.Flat;
            SelectProduct.ForeColor = Color.White;
            SelectProduct.Location = new Point(225, 9);
            SelectProduct.Name = "SelectProduct";
            SelectProduct.Size = new Size(184, 29);
            SelectProduct.TabIndex = 8;
            SelectProduct.Text = "выбрать продукт";
            SelectProduct.UseVisualStyleBackColor = false;
            SelectProduct.Click += SelectProduct_Click;
            // 
            // NameProduct
            // 
            NameProduct.AutoSize = true;
            NameProduct.Location = new Point(435, 13);
            NameProduct.Name = "NameProduct";
            NameProduct.Size = new Size(152, 20);
            NameProduct.TabIndex = 7;
            NameProduct.Text = "Выбранный продукт";
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
            // ProductsList
            // 
            ProductsList.BackColor = Color.White;
            ProductsList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader7, columnHeader5, columnHeader8, columnHeader10, columnHeader11 });
            ProductsList.Dock = DockStyle.Fill;
            ProductsList.FullRowSelect = true;
            ProductsList.GridLines = true;
            ProductsList.Location = new Point(0, 47);
            ProductsList.MultiSelect = false;
            ProductsList.Name = "ProductsList";
            ProductsList.Scrollable = false;
            ProductsList.Size = new Size(1139, 662);
            ProductsList.TabIndex = 4;
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
            columnHeader2.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Описание";
            columnHeader7.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Тип операции";
            columnHeader5.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Получатель";
            columnHeader8.Width = 120;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "ID получателя";
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Количество";
            columnHeader11.Width = 120;
            // 
            // OperationsWithProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1139, 709);
            Controls.Add(ProductsList);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OperationsWithProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OperationsWithProductsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button NextPageButton;
        private Button UpdatePageButton;
        private Button PrevPageButton;
        private ListView ProductsList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button SelectProduct;
        private Label NameProduct;
    }
}