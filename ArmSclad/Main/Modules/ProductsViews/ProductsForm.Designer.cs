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
            ProductsList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel2 = new Panel();
            DeleteProduct = new Button();
            AddProduct = new Button();
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
            // ProductsList
            // 
            ProductsList.BackColor = Color.White;
            ProductsList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader7, columnHeader3, columnHeader9, columnHeader6, columnHeader4 });
            ProductsList.Dock = DockStyle.Fill;
            ProductsList.FullRowSelect = true;
            ProductsList.GridLines = true;
            ProductsList.Location = new Point(0, 47);
            ProductsList.MultiSelect = false;
            ProductsList.Name = "ProductsList";
            ProductsList.Scrollable = false;
            ProductsList.Size = new Size(1139, 662);
            ProductsList.TabIndex = 3;
            ProductsList.UseCompatibleStateImageBehavior = false;
            ProductsList.View = System.Windows.Forms.View.Details;
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
            // columnHeader3
            // 
            columnHeader3.Text = "Кол-во ед. в упаковке";
            columnHeader3.Width = 170;
            // 
            // columnHeader9
            // 
            columnHeader9.DisplayIndex = 5;
            columnHeader9.Text = "Занимаемое место упаковкой";
            columnHeader9.Width = 180;
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 4;
            columnHeader6.Text = "Стоимость за ед.";
            columnHeader6.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Стоимость за упаковку";
            columnHeader4.Width = 200;
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
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 709);
            Controls.Add(panel2);
            Controls.Add(ProductsList);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsForm";
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
        private ListView ProductsList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader4;
        private Panel panel2;
        private Button AddProduct;
        private Button DeleteProduct;
        private CheckBox UpdateMode;
    }
}