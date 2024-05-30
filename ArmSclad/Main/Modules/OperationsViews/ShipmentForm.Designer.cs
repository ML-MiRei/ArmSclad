namespace ArmSclad.UI.Main.Modules.StoragesViews.OperationsViews
{
    partial class ShipmentForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            CloseButton = new Button();
            panel2 = new Panel();
            ProductsList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            CancelButton = new Button();
            CompleteButton = new Button();
            SelectProduct = new Button();
            SelectClient = new Button();
            label3 = new Label();
            NameClient = new Label();
            label1 = new Label();
            productEntityBindingSource = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            shipmentFormBindingSource = new BindingSource(components);
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productEntityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shipmentFormBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 52);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 16);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 1;
            label2.Text = "Оформление отгрузки";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(454, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(63, 52);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ProductsList);
            panel2.Controls.Add(CancelButton);
            panel2.Controls.Add(CompleteButton);
            panel2.Controls.Add(SelectProduct);
            panel2.Controls.Add(SelectClient);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(NameClient);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 388);
            panel2.TabIndex = 1;
            // 
            // ProductsList
            // 
            ProductsList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            ProductsList.GridLines = true;
            ProductsList.Location = new Point(34, 127);
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(430, 176);
            ProductsList.TabIndex = 9;
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
            CancelButton.Location = new Point(272, 328);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(192, 29);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "отмена";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // CompleteButton
            // 
            CompleteButton.BackColor = Color.Green;
            CompleteButton.FlatAppearance.BorderSize = 0;
            CompleteButton.FlatStyle = FlatStyle.Flat;
            CompleteButton.ForeColor = Color.White;
            CompleteButton.Location = new Point(34, 328);
            CompleteButton.Name = "CompleteButton";
            CompleteButton.Size = new Size(192, 29);
            CompleteButton.TabIndex = 6;
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
            SelectProduct.Location = new Point(288, 77);
            SelectProduct.Name = "SelectProduct";
            SelectProduct.Size = new Size(176, 29);
            SelectProduct.TabIndex = 4;
            SelectProduct.Text = "выбор продуктов";
            SelectProduct.UseVisualStyleBackColor = false;
            SelectProduct.Click += SelectProduct_Click;
            // 
            // SelectClient
            // 
            SelectClient.BackColor = Color.FromArgb(0, 0, 64);
            SelectClient.FlatAppearance.BorderSize = 0;
            SelectClient.FlatStyle = FlatStyle.Flat;
            SelectClient.ForeColor = Color.White;
            SelectClient.Location = new Point(288, 34);
            SelectClient.Name = "SelectClient";
            SelectClient.Size = new Size(176, 29);
            SelectClient.TabIndex = 3;
            SelectClient.Text = "выбор клиента";
            SelectClient.UseVisualStyleBackColor = false;
            SelectClient.Click += SelectClient_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 81);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 2;
            label3.Text = "Выбранные продукты:";
            // 
            // NameClient
            // 
            NameClient.AutoSize = true;
            NameClient.Location = new Point(143, 38);
            NameClient.Name = "NameClient";
            NameClient.Size = new Size(98, 20);
            NameClient.TabIndex = 1;
            NameClient.Text = "Имя клиента";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 38);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Клиент:";
            // 
            // productEntityBindingSource
            // 
            productEntityBindingSource.DataSource = typeof(Core.Entities.ProductEntity);
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Infrastructure.Database.Model.Product);
            // 
            // shipmentFormBindingSource
            // 
            shipmentFormBindingSource.DataSource = typeof(ShipmentForm);
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(528, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 440);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 440);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 0, 64);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(538, 10);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 0, 64);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(10, 440);
            panel6.Name = "panel6";
            panel6.Size = new Size(518, 10);
            panel6.TabIndex = 5;
            // 
            // ShipmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 450);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShipmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShipmentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productEntityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)shipmentFormBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CloseButton;
        private Panel panel2;
        private Button SelectProduct;
        private Button SelectClient;
        private Label label3;
        private Label NameClient;
        private Label label1;
        private Button CancelButton;
        private Button CompleteButton;
        private Label label2;
        private BindingSource productBindingSource;
        private BindingSource shipmentFormBindingSource;
        private BindingSource productEntityBindingSource;
        private ListView ProductsList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}