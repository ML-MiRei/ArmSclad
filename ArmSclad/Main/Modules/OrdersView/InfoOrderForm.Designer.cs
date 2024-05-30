namespace ArmSclad.UI.Main.Modules.OrdersView
{
    partial class InfoOrderForm
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
            label7 = new Label();
            CloseButton = new Button();
            panel2 = new Panel();
            ProductsList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SelectProduct = new Button();
            SelectClient = new Button();
            label1 = new Label();
            NameClient = new Label();
            label8 = new Label();
            CancelButton = new Button();
            SaveButton = new Button();
            AddressTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            DeliveryDatePicker = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 37);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 9);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 1;
            label7.Text = "Информация о заказе";
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(255, 128, 128);
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(512, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(65, 35);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(DeliveryDatePicker);
            panel2.Controls.Add(ProductsList);
            panel2.Controls.Add(SelectProduct);
            panel2.Controls.Add(SelectClient);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(NameClient);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(CancelButton);
            panel2.Controls.Add(SaveButton);
            panel2.Controls.Add(AddressTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 509);
            panel2.TabIndex = 3;
            // 
            // ProductsList
            // 
            ProductsList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            ProductsList.GridLines = true;
            ProductsList.Location = new Point(42, 121);
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(495, 176);
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
            // SelectProduct
            // 
            SelectProduct.BackColor = Color.FromArgb(0, 0, 64);
            SelectProduct.FlatAppearance.BorderSize = 0;
            SelectProduct.FlatStyle = FlatStyle.Flat;
            SelectProduct.ForeColor = Color.White;
            SelectProduct.Location = new Point(296, 71);
            SelectProduct.Name = "SelectProduct";
            SelectProduct.Size = new Size(241, 29);
            SelectProduct.TabIndex = 16;
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
            SelectClient.Location = new Point(296, 28);
            SelectClient.Name = "SelectClient";
            SelectClient.Size = new Size(241, 29);
            SelectClient.TabIndex = 15;
            SelectClient.Text = "выбор клиента";
            SelectClient.UseVisualStyleBackColor = false;
            SelectClient.Click += SelectClient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 75);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 14;
            label1.Text = "Выбранные продукты:";
            // 
            // NameClient
            // 
            NameClient.AutoSize = true;
            NameClient.Location = new Point(151, 32);
            NameClient.Name = "NameClient";
            NameClient.Size = new Size(98, 20);
            NameClient.TabIndex = 13;
            NameClient.Text = "Имя клиента";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 32);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 12;
            label8.Text = "Клиент:";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(192, 0, 0);
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(303, 423);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(233, 29);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Green;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(41, 423);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(233, 29);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(151, 320);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.PlaceholderText = "адрес..";
            AddressTextBox.Size = new Size(385, 27);
            AddressTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(41, 361);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 2;
            label4.Text = "Дата доставки:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(41, 319);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 1;
            label3.Text = "Адрес:";
            // 
            // DeliveryDatePicker
            // 
            DeliveryDatePicker.Location = new Point(286, 360);
            DeliveryDatePicker.Name = "DeliveryDatePicker";
            DeliveryDatePicker.Size = new Size(250, 27);
            DeliveryDatePicker.TabIndex = 18;
            // 
            // InfoOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(580, 546);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoOrderForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Button CloseButton;
        private Panel panel2;
        private Button CancelButton;
        private Button SaveButton;
        private TextBox AddressTextBox;
        private Label label4;
        private Label label3;
        private ListView ProductsList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button SelectProduct;
        private Button SelectClient;
        private Label label1;
        private Label NameClient;
        private Label label8;
        private DateTimePicker DeliveryDatePicker;
    }
}