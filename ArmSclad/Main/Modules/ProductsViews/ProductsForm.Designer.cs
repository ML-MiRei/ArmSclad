namespace ArmSclad.UI.Main.Modules.ProductsViews
{
    partial class ProductsForm
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
            UpdateMode = new CheckBox();
            NextPageButton = new Button();
            UpdatePageButton = new Button();
            PrevPageButton = new Button();
            panel2 = new Panel();
            DeleteProduct = new Button();
            AddProduct = new Button();
            ProductsList = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(UpdateMode);
            panel1.Controls.Add(NextPageButton);
            panel1.Controls.Add(UpdatePageButton);
            panel1.Controls.Add(PrevPageButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 47);
            panel1.TabIndex = 2;
            // 
            // UpdateMode
            // 
            UpdateMode.AutoSize = true;
            UpdateMode.Location = new Point(187, 12);
            UpdateMode.Name = "UpdateMode";
            UpdateMode.Size = new Size(198, 24);
            UpdateMode.TabIndex = 8;
            UpdateMode.Text = "режим редактирования";
            UpdateMode.UseVisualStyleBackColor = true;
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
            panel2.Controls.Add(DeleteProduct);
            panel2.Controls.Add(AddProduct);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 647);
            panel2.Name = "panel2";
            panel2.Size = new Size(1139, 62);
            panel2.TabIndex = 4;
            // 
            // DeleteProduct
            // 
            DeleteProduct.BackColor = Color.FromArgb(192, 0, 0);
            DeleteProduct.FlatAppearance.BorderSize = 0;
            DeleteProduct.FlatStyle = FlatStyle.Flat;
            DeleteProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteProduct.ForeColor = Color.White;
            DeleteProduct.Image = Properties.Resources.icons8_мусор_24;
            DeleteProduct.Location = new Point(106, 13);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(77, 37);
            DeleteProduct.TabIndex = 1;
            DeleteProduct.UseVisualStyleBackColor = false;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // AddProduct
            // 
            AddProduct.BackColor = Color.FromArgb(0, 0, 64);
            AddProduct.FlatAppearance.BorderSize = 0;
            AddProduct.FlatStyle = FlatStyle.Flat;
            AddProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddProduct.ForeColor = Color.White;
            AddProduct.Location = new Point(12, 13);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(77, 37);
            AddProduct.TabIndex = 0;
            AddProduct.Text = "+";
            AddProduct.UseVisualStyleBackColor = false;
            AddProduct.Click += AddProduct_Click;
            // 
            // ProductsList
            // 
            ProductsList.BackColor = Color.White;
            ProductsList.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader6, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13 });
            ProductsList.Dock = DockStyle.Fill;
            ProductsList.FullRowSelect = true;
            ProductsList.GridLines = true;
            ProductsList.Location = new Point(0, 47);
            ProductsList.MultiSelect = false;
            ProductsList.Name = "ProductsList";
            ProductsList.Scrollable = false;
            ProductsList.Size = new Size(1139, 600);
            ProductsList.TabIndex = 10;
            ProductsList.UseCompatibleStateImageBehavior = false;
            ProductsList.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ID";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Название";
            columnHeader6.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Описание";
            columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Кол-во ед. в упаковке";
            columnHeader10.Width = 170;
            // 
            // columnHeader11
            // 
            columnHeader11.DisplayIndex = 5;
            columnHeader11.Text = "Занимаемое место упаковкой";
            columnHeader11.Width = 180;
            // 
            // columnHeader12
            // 
            columnHeader12.DisplayIndex = 4;
            columnHeader12.Text = "Стоимость за ед.";
            columnHeader12.Width = 130;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Стоимость за упаковку";
            columnHeader13.Width = 200;
            // 
            // OperationsWithProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 709);
            Controls.Add(ProductsList);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OperationsWithProductsForm";
            Text = "ProductsForm";
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
        private Panel panel2;
        private Button AddProduct;
        private Button DeleteProduct;
        private CheckBox UpdateMode;
        private ListView ProductsList;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
    }
}