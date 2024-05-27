namespace ArmSclad.UI.Main.Modules.ClientsViews
{
    partial class ClientsForm
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
            ClientsList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
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
            panel1.Size = new Size(1121, 47);
            panel1.TabIndex = 3;
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
            panel2.Location = new Point(0, 600);
            panel2.Name = "panel2";
            panel2.Size = new Size(1121, 62);
            panel2.TabIndex = 5;
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
            // ClientsList
            // 
            ClientsList.BackColor = Color.White;
            ClientsList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            ClientsList.Dock = DockStyle.Fill;
            ClientsList.FullRowSelect = true;
            ClientsList.GridLines = true;
            ClientsList.Location = new Point(0, 47);
            ClientsList.MultiSelect = false;
            ClientsList.Name = "ClientsList";
            ClientsList.Scrollable = false;
            ClientsList.Size = new Size(1121, 553);
            ClientsList.TabIndex = 6;
            ClientsList.UseCompatibleStateImageBehavior = false;
            ClientsList.View = System.Windows.Forms.View.Details;
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
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 662);
            Controls.Add(ClientsList);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientsForm";
            Text = "ClientsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox UpdateMode;
        private Button NextPageButton;
        private Button UpdatePageButton;
        private Button PrevPageButton;
        private Panel panel2;
        private Button DeleteProduct;
        private Button AddProduct;
        private ListView ClientsList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}